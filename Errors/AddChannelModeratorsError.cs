using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddChannelModeratorsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddChannelModeratorsError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddChannelModeratorsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static AddChannelModeratorsError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static AddChannelModeratorsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddChannelModeratorsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddChannelModeratorsErrorResponse : IErrorResponse<AddChannelModeratorsError>
{
    public static AddChannelModeratorsErrorResponse Instance { get; } = new();

    private AddChannelModeratorsErrorResponse()
    {
    }

    public Task<AddChannelModeratorsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddChannelModeratorsError.Create(response, ct);
}
