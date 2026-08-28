using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CompleteStreamingUploadError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CompleteStreamingUploadError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CompleteStreamingUploadError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CompleteStreamingUploadError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CompleteStreamingUploadError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CompleteStreamingUploadErrorResponse : IErrorResponse<CompleteStreamingUploadError>
{
    public static CompleteStreamingUploadErrorResponse Instance { get; } = new();

    private CompleteStreamingUploadErrorResponse()
    {
    }

    public Task<CompleteStreamingUploadError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CompleteStreamingUploadError.Create(response, ct);
}
