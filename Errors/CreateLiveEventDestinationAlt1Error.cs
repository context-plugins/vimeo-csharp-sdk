using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CreateLiveEventDestinationAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateLiveEventDestinationAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateLiveEventDestinationAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateLiveEventDestinationAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateLiveEventDestinationAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateLiveEventDestinationAlt1ErrorResponse : IErrorResponse<CreateLiveEventDestinationAlt1Error>
{
    public static CreateLiveEventDestinationAlt1ErrorResponse Instance { get; } = new();

    private CreateLiveEventDestinationAlt1ErrorResponse()
    {
    }

    public Task<CreateLiveEventDestinationAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateLiveEventDestinationAlt1Error.Create(response, ct);
}
