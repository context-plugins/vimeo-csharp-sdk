using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteEmbedPresetAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteEmbedPresetAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteEmbedPresetAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteEmbedPresetAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteEmbedPresetAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteEmbedPresetAlt1ErrorResponse : IErrorResponse<DeleteEmbedPresetAlt1Error>
{
    public static DeleteEmbedPresetAlt1ErrorResponse Instance { get; } = new();

    private DeleteEmbedPresetAlt1ErrorResponse()
    {
    }

    public Task<DeleteEmbedPresetAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteEmbedPresetAlt1Error.Create(response, ct);
}
