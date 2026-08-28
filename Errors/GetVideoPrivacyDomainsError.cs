using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVideoPrivacyDomainsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVideoPrivacyDomainsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVideoPrivacyDomainsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVideoPrivacyDomainsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVideoPrivacyDomainsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVideoPrivacyDomainsErrorResponse : IErrorResponse<GetVideoPrivacyDomainsError>
{
    public static GetVideoPrivacyDomainsErrorResponse Instance { get; } = new();

    private GetVideoPrivacyDomainsErrorResponse()
    {
    }

    public Task<GetVideoPrivacyDomainsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVideoPrivacyDomainsError.Create(response, ct);
}
