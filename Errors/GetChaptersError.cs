using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetChaptersError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetChaptersError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetChaptersError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetChaptersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetChaptersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChaptersErrorResponse : IErrorResponse<GetChaptersError>
{
    public static GetChaptersErrorResponse Instance { get; } = new();

    private GetChaptersErrorResponse()
    {
    }

    public Task<GetChaptersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChaptersError.Create(response, ct);
}
