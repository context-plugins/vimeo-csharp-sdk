using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class ToggleRleLowLatencyError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ToggleRleLowLatencyError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ToggleRleLowLatencyError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ToggleRleLowLatencyError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ToggleRleLowLatencyError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ToggleRleLowLatencyErrorResponse : IErrorResponse<ToggleRleLowLatencyError>
{
    public static ToggleRleLowLatencyErrorResponse Instance { get; } = new();

    private ToggleRleLowLatencyErrorResponse()
    {
    }

    public Task<ToggleRleLowLatencyError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ToggleRleLowLatencyError.Create(response, ct);
}
