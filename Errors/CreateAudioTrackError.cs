using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateAudioTrackError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateAudioTrackError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateAudioTrackError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateAudioTrackError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateAudioTrackError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateAudioTrackErrorResponse : IErrorResponse<CreateAudioTrackError>
{
    public static CreateAudioTrackErrorResponse Instance { get; } = new();

    private CreateAudioTrackErrorResponse()
    {
    }

    public Task<CreateAudioTrackError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateAudioTrackError.Create(response, ct);
}
