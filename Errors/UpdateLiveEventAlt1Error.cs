using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class UpdateLiveEventAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private UpdateLiveEventAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static UpdateLiveEventAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static UpdateLiveEventAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<UpdateLiveEventAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateLiveEventAlt1ErrorResponse : IErrorResponse<UpdateLiveEventAlt1Error>
{
    public static UpdateLiveEventAlt1ErrorResponse Instance { get; } = new();

    private UpdateLiveEventAlt1ErrorResponse()
    {
    }

    public Task<UpdateLiveEventAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateLiveEventAlt1Error.Create(response, ct);
}
