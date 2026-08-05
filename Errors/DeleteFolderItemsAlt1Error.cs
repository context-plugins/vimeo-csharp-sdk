using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteFolderItemsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteFolderItemsAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteFolderItemsAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteFolderItemsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteFolderItemsAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteFolderItemsAlt1ErrorResponse : IErrorResponse<DeleteFolderItemsAlt1Error>
{
    public static DeleteFolderItemsAlt1ErrorResponse Instance { get; } = new();

    private DeleteFolderItemsAlt1ErrorResponse()
    {
    }

    public Task<DeleteFolderItemsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteFolderItemsAlt1Error.Create(response, ct);
}
