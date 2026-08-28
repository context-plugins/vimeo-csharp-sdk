using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CheckIfUserLikedVideoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckIfUserLikedVideoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckIfUserLikedVideoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckIfUserLikedVideoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckIfUserLikedVideoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckIfUserLikedVideoErrorResponse : IErrorResponse<CheckIfUserLikedVideoError>
{
    public static CheckIfUserLikedVideoErrorResponse Instance { get; } = new();

    private CheckIfUserLikedVideoErrorResponse()
    {
    }

    public Task<CheckIfUserLikedVideoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckIfUserLikedVideoError.Create(response, ct);
}
