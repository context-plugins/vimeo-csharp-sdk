using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class RemoveVideosFromChannelError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private RemoveVideosFromChannelError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static RemoveVideosFromChannelError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static RemoveVideosFromChannelError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<RemoveVideosFromChannelError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveVideosFromChannelErrorResponse : IErrorResponse<RemoveVideosFromChannelError>
{
    public static RemoveVideosFromChannelErrorResponse Instance { get; } = new();

    private RemoveVideosFromChannelErrorResponse()
    {
    }

    public Task<RemoveVideosFromChannelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveVideosFromChannelError.Create(response, ct);
}
