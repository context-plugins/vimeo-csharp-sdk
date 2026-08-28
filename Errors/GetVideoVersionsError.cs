using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVideoVersionsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVideoVersionsError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVideoVersionsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static GetVideoVersionsError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static GetVideoVersionsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVideoVersionsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVideoVersionsErrorResponse : IErrorResponse<GetVideoVersionsError>
{
    public static GetVideoVersionsErrorResponse Instance { get; } = new();

    private GetVideoVersionsErrorResponse()
    {
    }

    public Task<GetVideoVersionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVideoVersionsError.Create(response, ct);
}
