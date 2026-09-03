using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class SetVideoAsShowcaseThumbnailAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SetVideoAsShowcaseThumbnailAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SetVideoAsShowcaseThumbnailAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SetVideoAsShowcaseThumbnailAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SetVideoAsShowcaseThumbnailAlt2Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetVideoAsShowcaseThumbnailAlt2ErrorResponse : IErrorResponse<SetVideoAsShowcaseThumbnailAlt2Error>
{
    public static SetVideoAsShowcaseThumbnailAlt2ErrorResponse Instance { get; } = new();

    private SetVideoAsShowcaseThumbnailAlt2ErrorResponse()
    {
    }

    public Task<SetVideoAsShowcaseThumbnailAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetVideoAsShowcaseThumbnailAlt2Error.Create(response, ct);
}
