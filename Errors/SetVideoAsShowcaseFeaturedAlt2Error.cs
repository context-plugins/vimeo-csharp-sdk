using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class SetVideoAsShowcaseFeaturedAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SetVideoAsShowcaseFeaturedAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SetVideoAsShowcaseFeaturedAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SetVideoAsShowcaseFeaturedAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SetVideoAsShowcaseFeaturedAlt2Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetVideoAsShowcaseFeaturedAlt2ErrorResponse : IErrorResponse<SetVideoAsShowcaseFeaturedAlt2Error>
{
    public static SetVideoAsShowcaseFeaturedAlt2ErrorResponse Instance { get; } = new();

    private SetVideoAsShowcaseFeaturedAlt2ErrorResponse()
    {
    }

    public Task<SetVideoAsShowcaseFeaturedAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetVideoAsShowcaseFeaturedAlt2Error.Create(response, ct);
}
