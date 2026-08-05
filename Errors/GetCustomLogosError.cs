using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetCustomLogosError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetCustomLogosError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetCustomLogosError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetCustomLogosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetCustomLogosError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCustomLogosErrorResponse : IErrorResponse<GetCustomLogosError>
{
    public static GetCustomLogosErrorResponse Instance { get; } = new();

    private GetCustomLogosErrorResponse()
    {
    }

    public Task<GetCustomLogosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCustomLogosError.Create(response, ct);
}
