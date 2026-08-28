using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditEmbedPresetAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private EditEmbedPresetAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static EditEmbedPresetAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static EditEmbedPresetAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<EditEmbedPresetAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditEmbedPresetAlt1ErrorResponse : IErrorResponse<EditEmbedPresetAlt1Error>
{
    public static EditEmbedPresetAlt1ErrorResponse Instance { get; } = new();

    private EditEmbedPresetAlt1ErrorResponse()
    {
    }

    public Task<EditEmbedPresetAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditEmbedPresetAlt1Error.Create(response, ct);
}
