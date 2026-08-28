using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateLiveEventError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateLiveEventError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateLiveEventError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static CreateLiveEventError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateLiveEventError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateLiveEventErrorResponse : IErrorResponse<CreateLiveEventError>
{
    public static CreateLiveEventErrorResponse Instance { get; } = new();

    private CreateLiveEventErrorResponse()
    {
    }

    public Task<CreateLiveEventError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateLiveEventError.Create(response, ct);
}
