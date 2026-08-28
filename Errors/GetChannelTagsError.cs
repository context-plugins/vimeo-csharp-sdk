using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetChannelTagsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetChannelTagsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetChannelTagsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetChannelTagsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetChannelTagsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChannelTagsErrorResponse : IErrorResponse<GetChannelTagsError>
{
    public static GetChannelTagsErrorResponse Instance { get; } = new();

    private GetChannelTagsErrorResponse()
    {
    }

    public Task<GetChannelTagsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChannelTagsError.Create(response, ct);
}
