using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteVideoFromGroupError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private readonly Optional<Error> _errorValue;

    private DeleteVideoFromGroupError(Optional<LegacyError> legacyErrorValue,
        Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
        _errorValue = errorValue;
    }

    private static DeleteVideoFromGroupError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default, default);

    private static DeleteVideoFromGroupError AsError(Error value) =>
        new(default, Optional<Error>.Some(value), default);

    private static DeleteVideoFromGroupError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteVideoFromGroupError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVideoFromGroupErrorResponse : IErrorResponse<DeleteVideoFromGroupError>
{
    public static DeleteVideoFromGroupErrorResponse Instance { get; } = new();

    private DeleteVideoFromGroupErrorResponse()
    {
    }

    public Task<DeleteVideoFromGroupError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVideoFromGroupError.Create(response, ct);
}
