using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVideoPrivacyUsersError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVideoPrivacyUsersError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVideoPrivacyUsersError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVideoPrivacyUsersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVideoPrivacyUsersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVideoPrivacyUsersErrorResponse : IErrorResponse<GetVideoPrivacyUsersError>
{
    public static GetVideoPrivacyUsersErrorResponse Instance { get; } = new();

    private GetVideoPrivacyUsersErrorResponse()
    {
    }

    public Task<GetVideoPrivacyUsersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVideoPrivacyUsersError.Create(response, ct);
}
