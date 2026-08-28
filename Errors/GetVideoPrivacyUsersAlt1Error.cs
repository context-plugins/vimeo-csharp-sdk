using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVideoPrivacyUsersAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVideoPrivacyUsersAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVideoPrivacyUsersAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVideoPrivacyUsersAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVideoPrivacyUsersAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVideoPrivacyUsersAlt1ErrorResponse : IErrorResponse<GetVideoPrivacyUsersAlt1Error>
{
    public static GetVideoPrivacyUsersAlt1ErrorResponse Instance { get; } = new();

    private GetVideoPrivacyUsersAlt1ErrorResponse()
    {
    }

    public Task<GetVideoPrivacyUsersAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVideoPrivacyUsersAlt1Error.Create(response, ct);
}
