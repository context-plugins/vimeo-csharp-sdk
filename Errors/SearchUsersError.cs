using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class SearchUsersError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private SearchUsersError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static SearchUsersError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static SearchUsersError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static SearchUsersError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<SearchUsersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            500 or 503 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SearchUsersErrorResponse : IErrorResponse<SearchUsersError>
{
    public static SearchUsersErrorResponse Instance { get; } = new();

    private SearchUsersErrorResponse()
    {
    }

    public Task<SearchUsersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SearchUsersError.Create(response, ct);
}
