using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetAudioTracksError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetAudioTracksError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetAudioTracksError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetAudioTracksError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetAudioTracksError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAudioTracksErrorResponse : IErrorResponse<GetAudioTracksError>
{
    public static GetAudioTracksErrorResponse Instance { get; } = new();

    private GetAudioTracksErrorResponse()
    {
    }

    public Task<GetAudioTracksError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAudioTracksError.Create(response, ct);
}
