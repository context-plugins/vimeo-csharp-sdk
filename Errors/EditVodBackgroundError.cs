using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class EditVodBackgroundError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private EditVodBackgroundError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static EditVodBackgroundError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static EditVodBackgroundError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<EditVodBackgroundError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditVodBackgroundErrorResponse : IErrorResponse<EditVodBackgroundError>
{
    public static EditVodBackgroundErrorResponse Instance { get; } = new();

    private EditVodBackgroundErrorResponse()
    {
    }

    public Task<EditVodBackgroundError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditVodBackgroundError.Create(response, ct);
}
