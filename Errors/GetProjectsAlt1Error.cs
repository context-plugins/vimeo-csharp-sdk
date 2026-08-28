using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetProjectsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetProjectsAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetProjectsAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetProjectsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetProjectsAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetProjectsAlt1ErrorResponse : IErrorResponse<GetProjectsAlt1Error>
{
    public static GetProjectsAlt1ErrorResponse Instance { get; } = new();

    private GetProjectsAlt1ErrorResponse()
    {
    }

    public Task<GetProjectsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetProjectsAlt1Error.Create(response, ct);
}
