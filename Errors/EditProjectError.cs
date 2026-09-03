using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class EditProjectError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EditProjectError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EditProjectError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static EditProjectError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EditProjectError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditProjectErrorResponse : IErrorResponse<EditProjectError>
{
    public static EditProjectErrorResponse Instance { get; } = new();

    private EditProjectErrorResponse()
    {
    }

    public Task<EditProjectError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditProjectError.Create(response, ct);
}
