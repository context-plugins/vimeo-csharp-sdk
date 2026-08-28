using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteChapterError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteChapterError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteChapterError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteChapterError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteChapterError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteChapterErrorResponse : IErrorResponse<DeleteChapterError>
{
    public static DeleteChapterErrorResponse Instance { get; } = new();

    private DeleteChapterErrorResponse()
    {
    }

    public Task<DeleteChapterError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteChapterError.Create(response, ct);
}
