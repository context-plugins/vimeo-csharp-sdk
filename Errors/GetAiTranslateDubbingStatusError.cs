using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetAiTranslateDubbingStatusError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetAiTranslateDubbingStatusError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetAiTranslateDubbingStatusError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static GetAiTranslateDubbingStatusError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static GetAiTranslateDubbingStatusError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetAiTranslateDubbingStatusError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 503 => FromJson<Error>(response, ct).As(AsError),
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAiTranslateDubbingStatusErrorResponse : IErrorResponse<GetAiTranslateDubbingStatusError>
{
    public static GetAiTranslateDubbingStatusErrorResponse Instance { get; } = new();

    private GetAiTranslateDubbingStatusErrorResponse()
    {
    }

    public Task<GetAiTranslateDubbingStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAiTranslateDubbingStatusError.Create(response, ct);
}
