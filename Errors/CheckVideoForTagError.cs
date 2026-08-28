using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CheckVideoForTagError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckVideoForTagError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckVideoForTagError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckVideoForTagError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckVideoForTagError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckVideoForTagErrorResponse : IErrorResponse<CheckVideoForTagError>
{
    public static CheckVideoForTagErrorResponse Instance { get; } = new();

    private CheckVideoForTagErrorResponse()
    {
    }

    public Task<CheckVideoForTagError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckVideoForTagError.Create(response, ct);
}
