using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideoTagsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideoTagsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideoTagsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideoTagsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideoTagsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoTagsErrorResponse : IErrorResponse<AddVideoTagsError>
{
    public static AddVideoTagsErrorResponse Instance { get; } = new();

    private AddVideoTagsErrorResponse()
    {
    }

    public Task<AddVideoTagsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoTagsError.Create(response, ct);
}
