using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetTranscriptMetadataError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetTranscriptMetadataError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetTranscriptMetadataError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetTranscriptMetadataError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetTranscriptMetadataError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTranscriptMetadataErrorResponse : IErrorResponse<GetTranscriptMetadataError>
{
    public static GetTranscriptMetadataErrorResponse Instance { get; } = new();

    private GetTranscriptMetadataErrorResponse()
    {
    }

    public Task<GetTranscriptMetadataError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTranscriptMetadataError.Create(response, ct);
}
