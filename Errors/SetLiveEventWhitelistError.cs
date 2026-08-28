using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class SetLiveEventWhitelistError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SetLiveEventWhitelistError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SetLiveEventWhitelistError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SetLiveEventWhitelistError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SetLiveEventWhitelistError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetLiveEventWhitelistErrorResponse : IErrorResponse<SetLiveEventWhitelistError>
{
    public static SetLiveEventWhitelistErrorResponse Instance { get; } = new();

    private SetLiveEventWhitelistErrorResponse()
    {
    }

    public Task<SetLiveEventWhitelistError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetLiveEventWhitelistError.Create(response, ct);
}
