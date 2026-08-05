using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CreateShowcaseCustomThumbError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateShowcaseCustomThumbError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateShowcaseCustomThumbError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateShowcaseCustomThumbError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateShowcaseCustomThumbError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateShowcaseCustomThumbErrorResponse : IErrorResponse<CreateShowcaseCustomThumbError>
{
    public static CreateShowcaseCustomThumbErrorResponse Instance { get; } = new();

    private CreateShowcaseCustomThumbErrorResponse()
    {
    }

    public Task<CreateShowcaseCustomThumbError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateShowcaseCustomThumbError.Create(response, ct);
}
