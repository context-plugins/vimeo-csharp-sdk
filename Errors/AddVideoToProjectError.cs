using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideoToProjectError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AddVideoToProjectError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AddVideoToProjectError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static AddVideoToProjectError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AddVideoToProjectError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoToProjectErrorResponse : IErrorResponse<AddVideoToProjectError>
{
    public static AddVideoToProjectErrorResponse Instance { get; } = new();

    private AddVideoToProjectErrorResponse()
    {
    }

    public Task<AddVideoToProjectError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoToProjectError.Create(response, ct);
}
