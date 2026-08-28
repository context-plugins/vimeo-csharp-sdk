using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class ReplaceVideosInShowcaseError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private ReplaceVideosInShowcaseError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static ReplaceVideosInShowcaseError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static ReplaceVideosInShowcaseError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<ReplaceVideosInShowcaseError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ReplaceVideosInShowcaseErrorResponse : IErrorResponse<ReplaceVideosInShowcaseError>
{
    public static ReplaceVideosInShowcaseErrorResponse Instance { get; } = new();

    private ReplaceVideosInShowcaseErrorResponse()
    {
    }

    public Task<ReplaceVideosInShowcaseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ReplaceVideosInShowcaseError.Create(response, ct);
}
