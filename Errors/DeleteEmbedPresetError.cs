using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteEmbedPresetError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteEmbedPresetError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteEmbedPresetError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteEmbedPresetError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteEmbedPresetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteEmbedPresetErrorResponse : IErrorResponse<DeleteEmbedPresetError>
{
    public static DeleteEmbedPresetErrorResponse Instance { get; } = new();

    private DeleteEmbedPresetErrorResponse()
    {
    }

    public Task<DeleteEmbedPresetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteEmbedPresetError.Create(response, ct);
}
