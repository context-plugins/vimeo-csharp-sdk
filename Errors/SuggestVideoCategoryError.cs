using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class SuggestVideoCategoryError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private SuggestVideoCategoryError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static SuggestVideoCategoryError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static SuggestVideoCategoryError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<SuggestVideoCategoryError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SuggestVideoCategoryErrorResponse : IErrorResponse<SuggestVideoCategoryError>
{
    public static SuggestVideoCategoryErrorResponse Instance { get; } = new();

    private SuggestVideoCategoryErrorResponse()
    {
    }

    public Task<SuggestVideoCategoryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SuggestVideoCategoryError.Create(response, ct);
}
