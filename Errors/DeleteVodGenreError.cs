using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteVodGenreError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVodGenreError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVodGenreError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVodGenreError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVodGenreError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVodGenreErrorResponse : IErrorResponse<DeleteVodGenreError>
{
    public static DeleteVodGenreErrorResponse Instance { get; } = new();

    private DeleteVodGenreErrorResponse()
    {
    }

    public Task<DeleteVodGenreError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVodGenreError.Create(response, ct);
}
