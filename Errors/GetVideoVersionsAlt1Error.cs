using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetVideoVersionsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVideoVersionsAlt1Error(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVideoVersionsAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static GetVideoVersionsAlt1Error AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static GetVideoVersionsAlt1Error AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVideoVersionsAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVideoVersionsAlt1ErrorResponse : IErrorResponse<GetVideoVersionsAlt1Error>
{
    public static GetVideoVersionsAlt1ErrorResponse Instance { get; } = new();

    private GetVideoVersionsAlt1ErrorResponse()
    {
    }

    public Task<GetVideoVersionsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVideoVersionsAlt1Error.Create(response, ct);
}
