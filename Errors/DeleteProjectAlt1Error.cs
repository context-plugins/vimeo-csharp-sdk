using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteProjectAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteProjectAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteProjectAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static DeleteProjectAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteProjectAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteProjectAlt1ErrorResponse : IErrorResponse<DeleteProjectAlt1Error>
{
    public static DeleteProjectAlt1ErrorResponse Instance { get; } = new();

    private DeleteProjectAlt1ErrorResponse()
    {
    }

    public Task<DeleteProjectAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteProjectAlt1Error.Create(response, ct);
}
