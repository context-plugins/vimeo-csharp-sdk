using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class UpdateVideoCustomMetadataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private UpdateVideoCustomMetadataError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static UpdateVideoCustomMetadataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static UpdateVideoCustomMetadataError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static UpdateVideoCustomMetadataError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<UpdateVideoCustomMetadataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            401 or 403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateVideoCustomMetadataErrorResponse : IErrorResponse<UpdateVideoCustomMetadataError>
{
    public static UpdateVideoCustomMetadataErrorResponse Instance { get; } = new();

    private UpdateVideoCustomMetadataErrorResponse()
    {
    }

    public Task<UpdateVideoCustomMetadataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateVideoCustomMetadataError.Create(response, ct);
}
