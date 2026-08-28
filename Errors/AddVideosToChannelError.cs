using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideosToChannelError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideosToChannelError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideosToChannelError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideosToChannelError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideosToChannelError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideosToChannelErrorResponse : IErrorResponse<AddVideosToChannelError>
{
    public static AddVideosToChannelErrorResponse Instance { get; } = new();

    private AddVideosToChannelErrorResponse()
    {
    }

    public Task<AddVideosToChannelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideosToChannelError.Create(response, ct);
}
