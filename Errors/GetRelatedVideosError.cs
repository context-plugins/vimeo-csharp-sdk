using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetRelatedVideosError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private readonly Optional<Error> _errorValue;

    private GetRelatedVideosError(Optional<LegacyError> legacyErrorValue,
        Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
        _errorValue = errorValue;
    }

    private static GetRelatedVideosError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default, default);

    private static GetRelatedVideosError AsError(Error value) =>
        new(default, Optional<Error>.Some(value), default);

    private static GetRelatedVideosError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetRelatedVideosError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetRelatedVideosErrorResponse : IErrorResponse<GetRelatedVideosError>
{
    public static GetRelatedVideosErrorResponse Instance { get; } = new();

    private GetRelatedVideosErrorResponse()
    {
    }

    public Task<GetRelatedVideosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetRelatedVideosError.Create(response, ct);
}
