using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideoPrivacyUserError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideoPrivacyUserError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideoPrivacyUserError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideoPrivacyUserError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideoPrivacyUserError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoPrivacyUserErrorResponse : IErrorResponse<AddVideoPrivacyUserError>
{
    public static AddVideoPrivacyUserErrorResponse Instance { get; } = new();

    private AddVideoPrivacyUserErrorResponse()
    {
    }

    public Task<AddVideoPrivacyUserError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoPrivacyUserError.Create(response, ct);
}
