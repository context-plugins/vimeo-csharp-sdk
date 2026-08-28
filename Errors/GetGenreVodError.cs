using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetGenreVodError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetGenreVodError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetGenreVodError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetGenreVodError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetGenreVodError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetGenreVodErrorResponse : IErrorResponse<GetGenreVodError>
{
    public static GetGenreVodErrorResponse Instance { get; } = new();

    private GetGenreVodErrorResponse()
    {
    }

    public Task<GetGenreVodError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetGenreVodError.Create(response, ct);
}
