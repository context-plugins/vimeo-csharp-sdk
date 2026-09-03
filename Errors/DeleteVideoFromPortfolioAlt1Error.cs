using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteVideoFromPortfolioAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVideoFromPortfolioAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVideoFromPortfolioAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVideoFromPortfolioAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVideoFromPortfolioAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVideoFromPortfolioAlt1ErrorResponse : IErrorResponse<DeleteVideoFromPortfolioAlt1Error>
{
    public static DeleteVideoFromPortfolioAlt1ErrorResponse Instance { get; } = new();

    private DeleteVideoFromPortfolioAlt1ErrorResponse()
    {
    }

    public Task<DeleteVideoFromPortfolioAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVideoFromPortfolioAlt1Error.Create(response, ct);
}
