using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class UpdateCustomMetadataFieldOptionsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private UpdateCustomMetadataFieldOptionsError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static UpdateCustomMetadataFieldOptionsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static UpdateCustomMetadataFieldOptionsError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static UpdateCustomMetadataFieldOptionsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<UpdateCustomMetadataFieldOptionsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            401 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateCustomMetadataFieldOptionsErrorResponse : IErrorResponse<UpdateCustomMetadataFieldOptionsError>
{
    public static UpdateCustomMetadataFieldOptionsErrorResponse Instance { get; } = new();

    private UpdateCustomMetadataFieldOptionsErrorResponse()
    {
    }

    public Task<UpdateCustomMetadataFieldOptionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateCustomMetadataFieldOptionsError.Create(response, ct);
}
