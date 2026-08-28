using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetAvailableVideoChannelsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetAvailableVideoChannelsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetAvailableVideoChannelsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetAvailableVideoChannelsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetAvailableVideoChannelsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAvailableVideoChannelsErrorResponse : IErrorResponse<GetAvailableVideoChannelsError>
{
    public static GetAvailableVideoChannelsErrorResponse Instance { get; } = new();

    private GetAvailableVideoChannelsErrorResponse()
    {
    }

    public Task<GetAvailableVideoChannelsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAvailableVideoChannelsError.Create(response, ct);
}
