using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CreateShowcaseError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateShowcaseError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateShowcaseError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateShowcaseError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateShowcaseError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateShowcaseErrorResponse : IErrorResponse<CreateShowcaseError>
{
    public static CreateShowcaseErrorResponse Instance { get; } = new();

    private CreateShowcaseErrorResponse()
    {
    }

    public Task<CreateShowcaseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateShowcaseError.Create(response, ct);
}
