using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetCustomLogosAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetCustomLogosAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetCustomLogosAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetCustomLogosAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetCustomLogosAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCustomLogosAlt1ErrorResponse : IErrorResponse<GetCustomLogosAlt1Error>
{
    public static GetCustomLogosAlt1ErrorResponse Instance { get; } = new();

    private GetCustomLogosAlt1ErrorResponse()
    {
    }

    public Task<GetCustomLogosAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCustomLogosAlt1Error.Create(response, ct);
}
