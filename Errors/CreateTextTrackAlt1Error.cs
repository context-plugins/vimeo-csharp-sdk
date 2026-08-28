using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateTextTrackAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateTextTrackAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateTextTrackAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateTextTrackAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateTextTrackAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateTextTrackAlt1ErrorResponse : IErrorResponse<CreateTextTrackAlt1Error>
{
    public static CreateTextTrackAlt1ErrorResponse Instance { get; } = new();

    private CreateTextTrackAlt1ErrorResponse()
    {
    }

    public Task<CreateTextTrackAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateTextTrackAlt1Error.Create(response, ct);
}
