using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AddVideosToProjectError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AddVideosToProjectError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AddVideosToProjectError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AddVideosToProjectError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AddVideosToProjectError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideosToProjectErrorResponse : IErrorResponse<AddVideosToProjectError>
{
    public static AddVideosToProjectErrorResponse Instance { get; } = new();

    private AddVideosToProjectErrorResponse()
    {
    }

    public Task<AddVideosToProjectError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideosToProjectError.Create(response, ct);
}
