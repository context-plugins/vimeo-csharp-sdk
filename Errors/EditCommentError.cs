using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class EditCommentError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EditCommentError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EditCommentError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static EditCommentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EditCommentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditCommentErrorResponse : IErrorResponse<EditCommentError>
{
    public static EditCommentErrorResponse Instance { get; } = new();

    private EditCommentErrorResponse()
    {
    }

    public Task<EditCommentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditCommentError.Create(response, ct);
}
