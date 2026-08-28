using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class UpdateLiveEventAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private UpdateLiveEventAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static UpdateLiveEventAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static UpdateLiveEventAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<UpdateLiveEventAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateLiveEventAlt2ErrorResponse : IErrorResponse<UpdateLiveEventAlt2Error>
{
    public static UpdateLiveEventAlt2ErrorResponse Instance { get; } = new();

    private UpdateLiveEventAlt2ErrorResponse()
    {
    }

    public Task<UpdateLiveEventAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateLiveEventAlt2Error.Create(response, ct);
}
