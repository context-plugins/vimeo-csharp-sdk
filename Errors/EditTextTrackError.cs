using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditTextTrackError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private EditTextTrackError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static EditTextTrackError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static EditTextTrackError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<EditTextTrackError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditTextTrackErrorResponse : IErrorResponse<EditTextTrackError>
{
    public static EditTextTrackErrorResponse Instance { get; } = new();

    private EditTextTrackErrorResponse()
    {
    }

    public Task<EditTextTrackError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditTextTrackError.Create(response, ct);
}
