using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetCommentRepliesError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetCommentRepliesError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetCommentRepliesError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetCommentRepliesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetCommentRepliesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCommentRepliesErrorResponse : IErrorResponse<GetCommentRepliesError>
{
    public static GetCommentRepliesErrorResponse Instance { get; } = new();

    private GetCommentRepliesErrorResponse()
    {
    }

    public Task<GetCommentRepliesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCommentRepliesError.Create(response, ct);
}
