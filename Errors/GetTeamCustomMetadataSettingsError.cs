using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetTeamCustomMetadataSettingsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private readonly Optional<Error> _errorValue;

    private GetTeamCustomMetadataSettingsError(Optional<LegacyError> legacyErrorValue,
        Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
        _errorValue = errorValue;
    }

    private static GetTeamCustomMetadataSettingsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default, default);

    private static GetTeamCustomMetadataSettingsError AsError(Error value) =>
        new(default, Optional<Error>.Some(value), default);

    private static GetTeamCustomMetadataSettingsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetTeamCustomMetadataSettingsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTeamCustomMetadataSettingsErrorResponse : IErrorResponse<GetTeamCustomMetadataSettingsError>
{
    public static GetTeamCustomMetadataSettingsErrorResponse Instance { get; } = new();

    private GetTeamCustomMetadataSettingsErrorResponse()
    {
    }

    public Task<GetTeamCustomMetadataSettingsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTeamCustomMetadataSettingsError.Create(response, ct);
}
