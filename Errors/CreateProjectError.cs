using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateProjectError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateProjectError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateProjectError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static CreateProjectError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateProjectError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateProjectErrorResponse : IErrorResponse<CreateProjectError>
{
    public static CreateProjectErrorResponse Instance { get; } = new();

    private CreateProjectErrorResponse()
    {
    }

    public Task<CreateProjectError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateProjectError.Create(response, ct);
}
