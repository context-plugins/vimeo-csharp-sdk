using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideoToShowcaseError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideoToShowcaseError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideoToShowcaseError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideoToShowcaseError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideoToShowcaseError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoToShowcaseErrorResponse : IErrorResponse<AddVideoToShowcaseError>
{
    public static AddVideoToShowcaseErrorResponse Instance { get; } = new();

    private AddVideoToShowcaseErrorResponse()
    {
    }

    public Task<AddVideoToShowcaseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoToShowcaseError.Create(response, ct);
}
