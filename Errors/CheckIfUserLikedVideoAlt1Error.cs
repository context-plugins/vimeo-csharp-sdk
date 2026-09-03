using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CheckIfUserLikedVideoAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckIfUserLikedVideoAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckIfUserLikedVideoAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckIfUserLikedVideoAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckIfUserLikedVideoAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckIfUserLikedVideoAlt1ErrorResponse : IErrorResponse<CheckIfUserLikedVideoAlt1Error>
{
    public static CheckIfUserLikedVideoAlt1ErrorResponse Instance { get; } = new();

    private CheckIfUserLikedVideoAlt1ErrorResponse()
    {
    }

    public Task<CheckIfUserLikedVideoAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckIfUserLikedVideoAlt1Error.Create(response, ct);
}
