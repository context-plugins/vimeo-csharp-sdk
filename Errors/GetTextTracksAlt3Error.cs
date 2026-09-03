using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetTextTracksAlt3Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetTextTracksAlt3Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetTextTracksAlt3Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetTextTracksAlt3Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetTextTracksAlt3Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTextTracksAlt3ErrorResponse : IErrorResponse<GetTextTracksAlt3Error>
{
    public static GetTextTracksAlt3ErrorResponse Instance { get; } = new();

    private GetTextTracksAlt3ErrorResponse()
    {
    }

    public Task<GetTextTracksAlt3Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTextTracksAlt3Error.Create(response, ct);
}
