using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetVodGenresByOndemandIdError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodGenresByOndemandIdError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodGenresByOndemandIdError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodGenresByOndemandIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodGenresByOndemandIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodGenresByOndemandIdErrorResponse : IErrorResponse<GetVodGenresByOndemandIdError>
{
    public static GetVodGenresByOndemandIdErrorResponse Instance { get; } = new();

    private GetVodGenresByOndemandIdErrorResponse()
    {
    }

    public Task<GetVodGenresByOndemandIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodGenresByOndemandIdError.Create(response, ct);
}
