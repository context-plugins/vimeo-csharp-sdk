using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class EditChannelError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private EditChannelError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static EditChannelError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static EditChannelError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<EditChannelError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditChannelErrorResponse : IErrorResponse<EditChannelError>
{
    public static EditChannelErrorResponse Instance { get; } = new();

    private EditChannelErrorResponse()
    {
    }

    public Task<EditChannelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditChannelError.Create(response, ct);
}
