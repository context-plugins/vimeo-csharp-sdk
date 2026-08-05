using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetAiQuestionsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetAiQuestionsError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetAiQuestionsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static GetAiQuestionsError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static GetAiQuestionsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetAiQuestionsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 503 => FromJson<Error>(response, ct).As(AsError),
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAiQuestionsErrorResponse : IErrorResponse<GetAiQuestionsError>
{
    public static GetAiQuestionsErrorResponse Instance { get; } = new();

    private GetAiQuestionsErrorResponse()
    {
    }

    public Task<GetAiQuestionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAiQuestionsError.Create(response, ct);
}
