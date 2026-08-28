using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteVideoEmbedPresetError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVideoEmbedPresetError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVideoEmbedPresetError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVideoEmbedPresetError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVideoEmbedPresetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVideoEmbedPresetErrorResponse : IErrorResponse<DeleteVideoEmbedPresetError>
{
    public static DeleteVideoEmbedPresetErrorResponse Instance { get; } = new();

    private DeleteVideoEmbedPresetErrorResponse()
    {
    }

    public Task<DeleteVideoEmbedPresetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVideoEmbedPresetError.Create(response, ct);
}
