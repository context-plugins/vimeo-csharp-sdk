using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetTranscriptError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetTranscriptError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetTranscriptError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetTranscriptError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetTranscriptError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTranscriptErrorResponse : IErrorResponse<GetTranscriptError>
{
    public static GetTranscriptErrorResponse Instance { get; } = new();

    private GetTranscriptErrorResponse()
    {
    }

    public Task<GetTranscriptError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTranscriptError.Create(response, ct);
}
