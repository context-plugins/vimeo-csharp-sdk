using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class ClipTrimError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ClipTrimError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ClipTrimError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static ClipTrimError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ClipTrimError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClipTrimErrorResponse : IErrorResponse<ClipTrimError>
{
    public static ClipTrimErrorResponse Instance { get; } = new();

    private ClipTrimErrorResponse()
    {
    }

    public Task<ClipTrimError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClipTrimError.Create(response, ct);
}
