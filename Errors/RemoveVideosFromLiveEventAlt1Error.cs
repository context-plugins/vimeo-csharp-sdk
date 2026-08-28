using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class RemoveVideosFromLiveEventAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RemoveVideosFromLiveEventAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RemoveVideosFromLiveEventAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RemoveVideosFromLiveEventAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RemoveVideosFromLiveEventAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveVideosFromLiveEventAlt1ErrorResponse : IErrorResponse<RemoveVideosFromLiveEventAlt1Error>
{
    public static RemoveVideosFromLiveEventAlt1ErrorResponse Instance { get; } = new();

    private RemoveVideosFromLiveEventAlt1ErrorResponse()
    {
    }

    public Task<RemoveVideosFromLiveEventAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveVideosFromLiveEventAlt1Error.Create(response, ct);
}
