using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetVodGenreError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodGenreError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodGenreError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodGenreError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodGenreError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodGenreErrorResponse : IErrorResponse<GetVodGenreError>
{
    public static GetVodGenreErrorResponse Instance { get; } = new();

    private GetVodGenreErrorResponse()
    {
    }

    public Task<GetVodGenreError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodGenreError.Create(response, ct);
}
