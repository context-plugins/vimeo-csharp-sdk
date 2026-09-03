using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CreateLiveEventAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateLiveEventAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateLiveEventAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateLiveEventAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateLiveEventAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateLiveEventAlt1ErrorResponse : IErrorResponse<CreateLiveEventAlt1Error>
{
    public static CreateLiveEventAlt1ErrorResponse Instance { get; } = new();

    private CreateLiveEventAlt1ErrorResponse()
    {
    }

    public Task<CreateLiveEventAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateLiveEventAlt1Error.Create(response, ct);
}
