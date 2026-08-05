using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetProjectsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetProjectsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetProjectsError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetProjectsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetProjectsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetProjectsErrorResponse : IErrorResponse<GetProjectsError>
{
    public static GetProjectsErrorResponse Instance { get; } = new();

    private GetProjectsErrorResponse()
    {
    }

    public Task<GetProjectsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetProjectsError.Create(response, ct);
}
