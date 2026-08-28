using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteVideoFromPortfolioError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVideoFromPortfolioError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVideoFromPortfolioError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVideoFromPortfolioError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVideoFromPortfolioError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVideoFromPortfolioErrorResponse : IErrorResponse<DeleteVideoFromPortfolioError>
{
    public static DeleteVideoFromPortfolioErrorResponse Instance { get; } = new();

    private DeleteVideoFromPortfolioErrorResponse()
    {
    }

    public Task<DeleteVideoFromPortfolioError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVideoFromPortfolioError.Create(response, ct);
}
