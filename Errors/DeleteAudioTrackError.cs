using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteAudioTrackError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteAudioTrackError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteAudioTrackError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteAudioTrackError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteAudioTrackError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteAudioTrackErrorResponse : IErrorResponse<DeleteAudioTrackError>
{
    public static DeleteAudioTrackErrorResponse Instance { get; } = new();

    private DeleteAudioTrackErrorResponse()
    {
    }

    public Task<DeleteAudioTrackError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteAudioTrackError.Create(response, ct);
}
