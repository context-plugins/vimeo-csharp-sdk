using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class RemoveChannelModeratorError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private RemoveChannelModeratorError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static RemoveChannelModeratorError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static RemoveChannelModeratorError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<RemoveChannelModeratorError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveChannelModeratorErrorResponse : IErrorResponse<RemoveChannelModeratorError>
{
    public static RemoveChannelModeratorErrorResponse Instance { get; } = new();

    private RemoveChannelModeratorErrorResponse()
    {
    }

    public Task<RemoveChannelModeratorError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveChannelModeratorError.Create(response, ct);
}
