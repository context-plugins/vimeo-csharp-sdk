using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class JoinGroupAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private readonly Optional<Error> _errorValue;

    private JoinGroupAlt1Error(Optional<LegacyError> legacyErrorValue,
        Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
        _errorValue = errorValue;
    }

    private static JoinGroupAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default, default);

    private static JoinGroupAlt1Error AsError(Error value) =>
        new(default, Optional<Error>.Some(value), default);

    private static JoinGroupAlt1Error AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<JoinGroupAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class JoinGroupAlt1ErrorResponse : IErrorResponse<JoinGroupAlt1Error>
{
    public static JoinGroupAlt1ErrorResponse Instance { get; } = new();

    private JoinGroupAlt1ErrorResponse()
    {
    }

    public Task<JoinGroupAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        JoinGroupAlt1Error.Create(response, ct);
}
