using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditShowcaseError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private EditShowcaseError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static EditShowcaseError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static EditShowcaseError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<EditShowcaseError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditShowcaseErrorResponse : IErrorResponse<EditShowcaseError>
{
    public static EditShowcaseErrorResponse Instance { get; } = new();

    private EditShowcaseErrorResponse()
    {
    }

    public Task<EditShowcaseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditShowcaseError.Create(response, ct);
}
