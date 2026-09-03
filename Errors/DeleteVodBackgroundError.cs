using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteVodBackgroundError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVodBackgroundError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVodBackgroundError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVodBackgroundError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVodBackgroundError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVodBackgroundErrorResponse : IErrorResponse<DeleteVodBackgroundError>
{
    public static DeleteVodBackgroundErrorResponse Instance { get; } = new();

    private DeleteVodBackgroundErrorResponse()
    {
    }

    public Task<DeleteVodBackgroundError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVodBackgroundError.Create(response, ct);
}
