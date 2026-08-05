using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetCommentError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetCommentError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetCommentError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetCommentError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetCommentError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCommentErrorResponse : IErrorResponse<GetCommentError>
{
    public static GetCommentErrorResponse Instance { get; } = new();

    private GetCommentErrorResponse()
    {
    }

    public Task<GetCommentError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCommentError.Create(response, ct);
}
