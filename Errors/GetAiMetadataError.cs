using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetAiMetadataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetAiMetadataError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetAiMetadataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static GetAiMetadataError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static GetAiMetadataError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetAiMetadataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 503 => FromJson<Error>(response, ct).As(AsError),
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAiMetadataErrorResponse : IErrorResponse<GetAiMetadataError>
{
    public static GetAiMetadataErrorResponse Instance { get; } = new();

    private GetAiMetadataErrorResponse()
    {
    }

    public Task<GetAiMetadataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAiMetadataError.Create(response, ct);
}
