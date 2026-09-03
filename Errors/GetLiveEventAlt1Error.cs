using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetLiveEventAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetLiveEventAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventAlt1ErrorResponse : IErrorResponse<GetLiveEventAlt1Error>
{
    public static GetLiveEventAlt1ErrorResponse Instance { get; } = new();

    private GetLiveEventAlt1ErrorResponse()
    {
    }

    public Task<GetLiveEventAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventAlt1Error.Create(response, ct);
}
