using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditAudioTrackError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private EditAudioTrackError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static EditAudioTrackError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static EditAudioTrackError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<EditAudioTrackError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditAudioTrackErrorResponse : IErrorResponse<EditAudioTrackError>
{
    public static EditAudioTrackErrorResponse Instance { get; } = new();

    private EditAudioTrackErrorResponse()
    {
    }

    public Task<EditAudioTrackError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditAudioTrackError.Create(response, ct);
}
