using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetChapterThumbnailError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetChapterThumbnailError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetChapterThumbnailError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetChapterThumbnailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetChapterThumbnailError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChapterThumbnailErrorResponse : IErrorResponse<GetChapterThumbnailError>
{
    public static GetChapterThumbnailErrorResponse Instance { get; } = new();

    private GetChapterThumbnailErrorResponse()
    {
    }

    public Task<GetChapterThumbnailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChapterThumbnailError.Create(response, ct);
}
