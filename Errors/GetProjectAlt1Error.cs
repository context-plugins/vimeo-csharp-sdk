using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetProjectAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetProjectAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetProjectAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetProjectAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetProjectAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetProjectAlt1ErrorResponse : IErrorResponse<GetProjectAlt1Error>
{
    public static GetProjectAlt1ErrorResponse Instance { get; } = new();

    private GetProjectAlt1ErrorResponse()
    {
    }

    public Task<GetProjectAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetProjectAlt1Error.Create(response, ct);
}
