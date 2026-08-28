using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateChapterError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateChapterError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateChapterError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateChapterError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateChapterError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateChapterErrorResponse : IErrorResponse<CreateChapterError>
{
    public static CreateChapterErrorResponse Instance { get; } = new();

    private CreateChapterErrorResponse()
    {
    }

    public Task<CreateChapterError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateChapterError.Create(response, ct);
}
