using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteVodRegionError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVodRegionError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVodRegionError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVodRegionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVodRegionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVodRegionErrorResponse : IErrorResponse<DeleteVodRegionError>
{
    public static DeleteVodRegionErrorResponse Instance { get; } = new();

    private DeleteVodRegionErrorResponse()
    {
    }

    public Task<DeleteVodRegionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVodRegionError.Create(response, ct);
}
