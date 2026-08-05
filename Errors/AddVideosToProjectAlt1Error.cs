using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AddVideosToProjectAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AddVideosToProjectAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AddVideosToProjectAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AddVideosToProjectAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AddVideosToProjectAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideosToProjectAlt1ErrorResponse : IErrorResponse<AddVideosToProjectAlt1Error>
{
    public static AddVideosToProjectAlt1ErrorResponse Instance { get; } = new();

    private AddVideosToProjectAlt1ErrorResponse()
    {
    }

    public Task<AddVideosToProjectAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideosToProjectAlt1Error.Create(response, ct);
}
