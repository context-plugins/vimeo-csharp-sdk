using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class ToggleRleLowLatencyAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ToggleRleLowLatencyAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ToggleRleLowLatencyAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ToggleRleLowLatencyAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ToggleRleLowLatencyAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ToggleRleLowLatencyAlt2ErrorResponse : IErrorResponse<ToggleRleLowLatencyAlt2Error>
{
    public static ToggleRleLowLatencyAlt2ErrorResponse Instance { get; } = new();

    private ToggleRleLowLatencyAlt2ErrorResponse()
    {
    }

    public Task<ToggleRleLowLatencyAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        ToggleRleLowLatencyAlt2Error.Create(response, ct);
}
