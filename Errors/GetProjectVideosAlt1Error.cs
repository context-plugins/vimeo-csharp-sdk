using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetProjectVideosAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetProjectVideosAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetProjectVideosAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetProjectVideosAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetProjectVideosAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetProjectVideosAlt1ErrorResponse : IErrorResponse<GetProjectVideosAlt1Error>
{
    public static GetProjectVideosAlt1ErrorResponse Instance { get; } = new();

    private GetProjectVideosAlt1ErrorResponse()
    {
    }

    public Task<GetProjectVideosAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetProjectVideosAlt1Error.Create(response, ct);
}
