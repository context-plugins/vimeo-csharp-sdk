using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetLiveEventWhitelistAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventWhitelistAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventWhitelistAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventWhitelistAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventWhitelistAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventWhitelistAlt1ErrorResponse : IErrorResponse<GetLiveEventWhitelistAlt1Error>
{
    public static GetLiveEventWhitelistAlt1ErrorResponse Instance { get; } = new();

    private GetLiveEventWhitelistAlt1ErrorResponse()
    {
    }

    public Task<GetLiveEventWhitelistAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventWhitelistAlt1Error.Create(response, ct);
}
