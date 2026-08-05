using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetEventAudioTracksError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetEventAudioTracksError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetEventAudioTracksError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetEventAudioTracksError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetEventAudioTracksError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetEventAudioTracksErrorResponse : IErrorResponse<GetEventAudioTracksError>
{
    public static GetEventAudioTracksErrorResponse Instance { get; } = new();

    private GetEventAudioTracksErrorResponse()
    {
    }

    public Task<GetEventAudioTracksError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetEventAudioTracksError.Create(response, ct);
}
