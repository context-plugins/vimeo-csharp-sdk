using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideoToVodError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideoToVodError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideoToVodError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideoToVodError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideoToVodError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoToVodErrorResponse : IErrorResponse<AddVideoToVodError>
{
    public static AddVideoToVodErrorResponse Instance { get; } = new();

    private AddVideoToVodErrorResponse()
    {
    }

    public Task<AddVideoToVodError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoToVodError.Create(response, ct);
}
