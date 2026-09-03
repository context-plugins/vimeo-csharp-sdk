using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetTextTracksAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetTextTracksAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetTextTracksAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetTextTracksAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetTextTracksAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTextTracksAlt1ErrorResponse : IErrorResponse<GetTextTracksAlt1Error>
{
    public static GetTextTracksAlt1ErrorResponse Instance { get; } = new();

    private GetTextTracksAlt1ErrorResponse()
    {
    }

    public Task<GetTextTracksAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTextTracksAlt1Error.Create(response, ct);
}
