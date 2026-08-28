using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteShowcaseCustomThumbnailError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteShowcaseCustomThumbnailError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteShowcaseCustomThumbnailError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteShowcaseCustomThumbnailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteShowcaseCustomThumbnailError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteShowcaseCustomThumbnailErrorResponse : IErrorResponse<DeleteShowcaseCustomThumbnailError>
{
    public static DeleteShowcaseCustomThumbnailErrorResponse Instance { get; } = new();

    private DeleteShowcaseCustomThumbnailErrorResponse()
    {
    }

    public Task<DeleteShowcaseCustomThumbnailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteShowcaseCustomThumbnailError.Create(response, ct);
}
