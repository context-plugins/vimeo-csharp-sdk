using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetProjectError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetProjectError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetProjectError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetProjectError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetProjectError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetProjectErrorResponse : IErrorResponse<GetProjectError>
{
    public static GetProjectErrorResponse Instance { get; } = new();

    private GetProjectErrorResponse()
    {
    }

    public Task<GetProjectError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetProjectError.Create(response, ct);
}
