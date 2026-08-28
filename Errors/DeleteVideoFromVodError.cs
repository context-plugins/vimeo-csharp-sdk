using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteVideoFromVodError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVideoFromVodError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVideoFromVodError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVideoFromVodError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVideoFromVodError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVideoFromVodErrorResponse : IErrorResponse<DeleteVideoFromVodError>
{
    public static DeleteVideoFromVodErrorResponse Instance { get; } = new();

    private DeleteVideoFromVodErrorResponse()
    {
    }

    public Task<DeleteVideoFromVodError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVideoFromVodError.Create(response, ct);
}
