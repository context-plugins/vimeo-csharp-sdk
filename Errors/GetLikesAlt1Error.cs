using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLikesAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLikesAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLikesAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetLikesAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLikesAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLikesAlt1ErrorResponse : IErrorResponse<GetLikesAlt1Error>
{
    public static GetLikesAlt1ErrorResponse Instance { get; } = new();

    private GetLikesAlt1ErrorResponse()
    {
    }

    public Task<GetLikesAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLikesAlt1Error.Create(response, ct);
}
