using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVodGenreByOndemandIdError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodGenreByOndemandIdError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodGenreByOndemandIdError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodGenreByOndemandIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodGenreByOndemandIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodGenreByOndemandIdErrorResponse : IErrorResponse<GetVodGenreByOndemandIdError>
{
    public static GetVodGenreByOndemandIdErrorResponse Instance { get; } = new();

    private GetVodGenreByOndemandIdErrorResponse()
    {
    }

    public Task<GetVodGenreByOndemandIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodGenreByOndemandIdError.Create(response, ct);
}
