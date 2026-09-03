using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetCustomLogoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetCustomLogoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetCustomLogoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetCustomLogoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetCustomLogoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCustomLogoErrorResponse : IErrorResponse<GetCustomLogoError>
{
    public static GetCustomLogoErrorResponse Instance { get; } = new();

    private GetCustomLogoErrorResponse()
    {
    }

    public Task<GetCustomLogoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCustomLogoError.Create(response, ct);
}
