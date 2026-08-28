using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class StartAiTranslateDubbingError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private StartAiTranslateDubbingError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static StartAiTranslateDubbingError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static StartAiTranslateDubbingError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static StartAiTranslateDubbingError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<StartAiTranslateDubbingError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 503 => FromJson<Error>(response, ct).As(AsError),
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class StartAiTranslateDubbingErrorResponse : IErrorResponse<StartAiTranslateDubbingError>
{
    public static StartAiTranslateDubbingErrorResponse Instance { get; } = new();

    private StartAiTranslateDubbingErrorResponse()
    {
    }

    public Task<StartAiTranslateDubbingError> Map(HttpResponseMessage response, CancellationToken ct) =>
        StartAiTranslateDubbingError.Create(response, ct);
}
