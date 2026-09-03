using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class LeaveGroupAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private readonly Optional<Error> _errorValue;

    private LeaveGroupAlt1Error(Optional<LegacyError> legacyErrorValue,
        Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
        _errorValue = errorValue;
    }

    private static LeaveGroupAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default, default);

    private static LeaveGroupAlt1Error AsError(Error value) =>
        new(default, Optional<Error>.Some(value), default);

    private static LeaveGroupAlt1Error AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<LeaveGroupAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class LeaveGroupAlt1ErrorResponse : IErrorResponse<LeaveGroupAlt1Error>
{
    public static LeaveGroupAlt1ErrorResponse Instance { get; } = new();

    private LeaveGroupAlt1ErrorResponse()
    {
    }

    public Task<LeaveGroupAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        LeaveGroupAlt1Error.Create(response, ct);
}
