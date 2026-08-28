using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetAudioTrackError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetAudioTrackError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetAudioTrackError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetAudioTrackError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetAudioTrackError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAudioTrackErrorResponse : IErrorResponse<GetAudioTrackError>
{
    public static GetAudioTrackErrorResponse Instance { get; } = new();

    private GetAudioTrackErrorResponse()
    {
    }

    public Task<GetAudioTrackError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAudioTrackError.Create(response, ct);
}
