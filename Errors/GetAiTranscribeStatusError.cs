using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetAiTranscribeStatusError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetAiTranscribeStatusError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetAiTranscribeStatusError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static GetAiTranscribeStatusError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static GetAiTranscribeStatusError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetAiTranscribeStatusError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<Error>(response, ct).As(AsError),
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAiTranscribeStatusErrorResponse : IErrorResponse<GetAiTranscribeStatusError>
{
    public static GetAiTranscribeStatusErrorResponse Instance { get; } = new();

    private GetAiTranscribeStatusErrorResponse()
    {
    }

    public Task<GetAiTranscribeStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAiTranscribeStatusError.Create(response, ct);
}
