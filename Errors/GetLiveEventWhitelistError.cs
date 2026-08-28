using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventWhitelistError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventWhitelistError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventWhitelistError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventWhitelistError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventWhitelistError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventWhitelistErrorResponse : IErrorResponse<GetLiveEventWhitelistError>
{
    public static GetLiveEventWhitelistErrorResponse Instance { get; } = new();

    private GetLiveEventWhitelistErrorResponse()
    {
    }

    public Task<GetLiveEventWhitelistError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventWhitelistError.Create(response, ct);
}
