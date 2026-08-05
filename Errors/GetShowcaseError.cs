using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetShowcaseError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetShowcaseError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetShowcaseError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetShowcaseError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetShowcaseError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetShowcaseErrorResponse : IErrorResponse<GetShowcaseError>
{
    public static GetShowcaseErrorResponse Instance { get; } = new();

    private GetShowcaseErrorResponse()
    {
    }

    public Task<GetShowcaseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetShowcaseError.Create(response, ct);
}
