using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideoPrivacyDomainError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideoPrivacyDomainError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideoPrivacyDomainError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideoPrivacyDomainError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideoPrivacyDomainError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoPrivacyDomainErrorResponse : IErrorResponse<AddVideoPrivacyDomainError>
{
    public static AddVideoPrivacyDomainErrorResponse Instance { get; } = new();

    private AddVideoPrivacyDomainErrorResponse()
    {
    }

    public Task<AddVideoPrivacyDomainError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoPrivacyDomainError.Create(response, ct);
}
