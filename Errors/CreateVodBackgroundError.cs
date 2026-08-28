using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateVodBackgroundError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateVodBackgroundError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateVodBackgroundError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateVodBackgroundError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateVodBackgroundError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateVodBackgroundErrorResponse : IErrorResponse<CreateVodBackgroundError>
{
    public static CreateVodBackgroundErrorResponse Instance { get; } = new();

    private CreateVodBackgroundErrorResponse()
    {
    }

    public Task<CreateVodBackgroundError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateVodBackgroundError.Create(response, ct);
}
