using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AddVideoToChannelError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideoToChannelError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideoToChannelError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideoToChannelError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideoToChannelError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoToChannelErrorResponse : IErrorResponse<AddVideoToChannelError>
{
    public static AddVideoToChannelErrorResponse Instance { get; } = new();

    private AddVideoToChannelErrorResponse()
    {
    }

    public Task<AddVideoToChannelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoToChannelError.Create(response, ct);
}
