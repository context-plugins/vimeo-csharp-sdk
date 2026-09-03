using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetPrivateToMeFolderError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetPrivateToMeFolderError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetPrivateToMeFolderError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetPrivateToMeFolderError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetPrivateToMeFolderError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPrivateToMeFolderErrorResponse : IErrorResponse<GetPrivateToMeFolderError>
{
    public static GetPrivateToMeFolderErrorResponse Instance { get; } = new();

    private GetPrivateToMeFolderErrorResponse()
    {
    }

    public Task<GetPrivateToMeFolderError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPrivateToMeFolderError.Create(response, ct);
}
