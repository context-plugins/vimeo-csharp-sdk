using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetFeedAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFeedAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFeedAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetFeedAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFeedAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFeedAlt1ErrorResponse : IErrorResponse<GetFeedAlt1Error>
{
    public static GetFeedAlt1ErrorResponse Instance { get; } = new();

    private GetFeedAlt1ErrorResponse()
    {
    }

    public Task<GetFeedAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFeedAlt1Error.Create(response, ct);
}
