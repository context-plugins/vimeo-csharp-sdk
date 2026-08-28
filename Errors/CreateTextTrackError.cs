using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateTextTrackError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateTextTrackError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateTextTrackError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateTextTrackError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateTextTrackError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateTextTrackErrorResponse : IErrorResponse<CreateTextTrackError>
{
    public static CreateTextTrackErrorResponse Instance { get; } = new();

    private CreateTextTrackErrorResponse()
    {
    }

    public Task<CreateTextTrackError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateTextTrackError.Create(response, ct);
}
