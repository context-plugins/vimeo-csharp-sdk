using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetGroupVideoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetGroupVideoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetGroupVideoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetGroupVideoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetGroupVideoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetGroupVideoErrorResponse : IErrorResponse<GetGroupVideoError>
{
    public static GetGroupVideoErrorResponse Instance { get; } = new();

    private GetGroupVideoErrorResponse()
    {
    }

    public Task<GetGroupVideoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetGroupVideoError.Create(response, ct);
}
