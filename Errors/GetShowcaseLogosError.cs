using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetShowcaseLogosError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetShowcaseLogosError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetShowcaseLogosError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetShowcaseLogosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetShowcaseLogosError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetShowcaseLogosErrorResponse : IErrorResponse<GetShowcaseLogosError>
{
    public static GetShowcaseLogosErrorResponse Instance { get; } = new();

    private GetShowcaseLogosErrorResponse()
    {
    }

    public Task<GetShowcaseLogosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetShowcaseLogosError.Create(response, ct);
}
