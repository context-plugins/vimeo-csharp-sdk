using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CreateCommentAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateCommentAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateCommentAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static CreateCommentAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateCommentAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateCommentAlt1ErrorResponse : IErrorResponse<CreateCommentAlt1Error>
{
    public static CreateCommentAlt1ErrorResponse Instance { get; } = new();

    private CreateCommentAlt1ErrorResponse()
    {
    }

    public Task<CreateCommentAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateCommentAlt1Error.Create(response, ct);
}
