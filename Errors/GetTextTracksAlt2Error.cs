using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetTextTracksAlt2Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetTextTracksAlt2Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetTextTracksAlt2Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetTextTracksAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetTextTracksAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTextTracksAlt2ErrorResponse : IErrorResponse<GetTextTracksAlt2Error>
{
    public static GetTextTracksAlt2ErrorResponse Instance { get; } = new();

    private GetTextTracksAlt2ErrorResponse()
    {
    }

    public Task<GetTextTracksAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTextTracksAlt2Error.Create(response, ct);
}
