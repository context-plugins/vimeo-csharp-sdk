using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteChapterThumbnailError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteChapterThumbnailError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteChapterThumbnailError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteChapterThumbnailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteChapterThumbnailError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteChapterThumbnailErrorResponse : IErrorResponse<DeleteChapterThumbnailError>
{
    public static DeleteChapterThumbnailErrorResponse Instance { get; } = new();

    private DeleteChapterThumbnailErrorResponse()
    {
    }

    public Task<DeleteChapterThumbnailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteChapterThumbnailError.Create(response, ct);
}
