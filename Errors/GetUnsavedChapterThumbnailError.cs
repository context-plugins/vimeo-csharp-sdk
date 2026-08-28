using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetUnsavedChapterThumbnailError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetUnsavedChapterThumbnailError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetUnsavedChapterThumbnailError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetUnsavedChapterThumbnailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetUnsavedChapterThumbnailError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetUnsavedChapterThumbnailErrorResponse : IErrorResponse<GetUnsavedChapterThumbnailError>
{
    public static GetUnsavedChapterThumbnailErrorResponse Instance { get; } = new();

    private GetUnsavedChapterThumbnailErrorResponse()
    {
    }

    public Task<GetUnsavedChapterThumbnailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetUnsavedChapterThumbnailError.Create(response, ct);
}
