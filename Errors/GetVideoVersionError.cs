using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVideoVersionError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVideoVersionError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVideoVersionError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVideoVersionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVideoVersionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVideoVersionErrorResponse : IErrorResponse<GetVideoVersionError>
{
    public static GetVideoVersionErrorResponse Instance { get; } = new();

    private GetVideoVersionErrorResponse()
    {
    }

    public Task<GetVideoVersionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVideoVersionError.Create(response, ct);
}
