using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateProjectAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateProjectAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateProjectAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static CreateProjectAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateProjectAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateProjectAlt1ErrorResponse : IErrorResponse<CreateProjectAlt1Error>
{
    public static CreateProjectAlt1ErrorResponse Instance { get; } = new();

    private CreateProjectAlt1ErrorResponse()
    {
    }

    public Task<CreateProjectAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateProjectAlt1Error.Create(response, ct);
}
