using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateCommentReplyError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateCommentReplyError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateCommentReplyError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateCommentReplyError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateCommentReplyError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateCommentReplyErrorResponse : IErrorResponse<CreateCommentReplyError>
{
    public static CreateCommentReplyErrorResponse Instance { get; } = new();

    private CreateCommentReplyErrorResponse()
    {
    }

    public Task<CreateCommentReplyError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateCommentReplyError.Create(response, ct);
}
