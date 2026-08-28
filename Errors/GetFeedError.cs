using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetFeedError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetFeedError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetFeedError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetFeedError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetFeedError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetFeedErrorResponse : IErrorResponse<GetFeedError>
{
    public static GetFeedErrorResponse Instance { get; } = new();

    private GetFeedErrorResponse()
    {
    }

    public Task<GetFeedError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetFeedError.Create(response, ct);
}
