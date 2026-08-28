using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteVodDraftError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVodDraftError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVodDraftError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVodDraftError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVodDraftError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVodDraftErrorResponse : IErrorResponse<DeleteVodDraftError>
{
    public static DeleteVodDraftErrorResponse Instance { get; } = new();

    private DeleteVodDraftErrorResponse()
    {
    }

    public Task<DeleteVodDraftError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVodDraftError.Create(response, ct);
}
