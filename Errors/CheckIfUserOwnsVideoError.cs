using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CheckIfUserOwnsVideoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckIfUserOwnsVideoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckIfUserOwnsVideoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckIfUserOwnsVideoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckIfUserOwnsVideoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckIfUserOwnsVideoErrorResponse : IErrorResponse<CheckIfUserOwnsVideoError>
{
    public static CheckIfUserOwnsVideoErrorResponse Instance { get; } = new();

    private CheckIfUserOwnsVideoErrorResponse()
    {
    }

    public Task<CheckIfUserOwnsVideoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckIfUserOwnsVideoError.Create(response, ct);
}
