using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetUserVodsAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetUserVodsAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetUserVodsAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetUserVodsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetUserVodsAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetUserVodsAlt1ErrorResponse : IErrorResponse<GetUserVodsAlt1Error>
{
    public static GetUserVodsAlt1ErrorResponse Instance { get; } = new();

    private GetUserVodsAlt1ErrorResponse()
    {
    }

    public Task<GetUserVodsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetUserVodsAlt1Error.Create(response, ct);
}
