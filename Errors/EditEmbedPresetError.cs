using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class EditEmbedPresetError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private EditEmbedPresetError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static EditEmbedPresetError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static EditEmbedPresetError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<EditEmbedPresetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditEmbedPresetErrorResponse : IErrorResponse<EditEmbedPresetError>
{
    public static EditEmbedPresetErrorResponse Instance { get; } = new();

    private EditEmbedPresetErrorResponse()
    {
    }

    public Task<EditEmbedPresetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditEmbedPresetError.Create(response, ct);
}
