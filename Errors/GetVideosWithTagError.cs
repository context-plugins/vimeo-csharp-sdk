using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVideosWithTagError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVideosWithTagError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVideosWithTagError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVideosWithTagError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVideosWithTagError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVideosWithTagErrorResponse : IErrorResponse<GetVideosWithTagError>
{
    public static GetVideosWithTagErrorResponse Instance { get; } = new();

    private GetVideosWithTagErrorResponse()
    {
    }

    public Task<GetVideosWithTagError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVideosWithTagError.Create(response, ct);
}
