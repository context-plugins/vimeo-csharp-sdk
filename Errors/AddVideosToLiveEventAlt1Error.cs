using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideosToLiveEventAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AddVideosToLiveEventAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AddVideosToLiveEventAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AddVideosToLiveEventAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AddVideosToLiveEventAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideosToLiveEventAlt1ErrorResponse : IErrorResponse<AddVideosToLiveEventAlt1Error>
{
    public static AddVideosToLiveEventAlt1ErrorResponse Instance { get; } = new();

    private AddVideosToLiveEventAlt1ErrorResponse()
    {
    }

    public Task<AddVideosToLiveEventAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideosToLiveEventAlt1Error.Create(response, ct);
}
