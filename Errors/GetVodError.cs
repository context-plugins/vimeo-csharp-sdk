using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVodError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodErrorResponse : IErrorResponse<GetVodError>
{
    public static GetVodErrorResponse Instance { get; } = new();

    private GetVodErrorResponse()
    {
    }

    public Task<GetVodError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodError.Create(response, ct);
}
