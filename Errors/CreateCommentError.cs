using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateCommentError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateCommentError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateCommentError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static CreateCommentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateCommentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateCommentErrorResponse : IErrorResponse<CreateCommentError>
{
    public static CreateCommentErrorResponse Instance { get; } = new();

    private CreateCommentErrorResponse()
    {
    }

    public Task<CreateCommentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateCommentError.Create(response, ct);
}
