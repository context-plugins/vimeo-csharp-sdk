using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetVideoCreditError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVideoCreditError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVideoCreditError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVideoCreditError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVideoCreditError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVideoCreditErrorResponse : IErrorResponse<GetVideoCreditError>
{
    public static GetVideoCreditErrorResponse Instance { get; } = new();

    private GetVideoCreditErrorResponse()
    {
    }

    public Task<GetVideoCreditError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVideoCreditError.Create(response, ct);
}
