using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class ToggleRleLowLatencyAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ToggleRleLowLatencyAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ToggleRleLowLatencyAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ToggleRleLowLatencyAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ToggleRleLowLatencyAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ToggleRleLowLatencyAlt1ErrorResponse : IErrorResponse<ToggleRleLowLatencyAlt1Error>
{
    public static ToggleRleLowLatencyAlt1ErrorResponse Instance { get; } = new();

    private ToggleRleLowLatencyAlt1ErrorResponse()
    {
    }

    public Task<ToggleRleLowLatencyAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        ToggleRleLowLatencyAlt1Error.Create(response, ct);
}
