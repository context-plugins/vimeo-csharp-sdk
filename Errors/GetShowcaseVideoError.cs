using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetShowcaseVideoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetShowcaseVideoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetShowcaseVideoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetShowcaseVideoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetShowcaseVideoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetShowcaseVideoErrorResponse : IErrorResponse<GetShowcaseVideoError>
{
    public static GetShowcaseVideoErrorResponse Instance { get; } = new();

    private GetShowcaseVideoErrorResponse()
    {
    }

    public Task<GetShowcaseVideoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetShowcaseVideoError.Create(response, ct);
}
