using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetChannelSubscribersError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetChannelSubscribersError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetChannelSubscribersError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetChannelSubscribersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetChannelSubscribersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChannelSubscribersErrorResponse : IErrorResponse<GetChannelSubscribersError>
{
    public static GetChannelSubscribersErrorResponse Instance { get; } = new();

    private GetChannelSubscribersErrorResponse()
    {
    }

    public Task<GetChannelSubscribersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChannelSubscribersError.Create(response, ct);
}
