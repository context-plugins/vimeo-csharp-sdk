using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteProjectError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteProjectError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteProjectError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static DeleteProjectError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteProjectError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteProjectErrorResponse : IErrorResponse<DeleteProjectError>
{
    public static DeleteProjectErrorResponse Instance { get; } = new();

    private DeleteProjectErrorResponse()
    {
    }

    public Task<DeleteProjectError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteProjectError.Create(response, ct);
}
