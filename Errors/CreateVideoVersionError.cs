using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateVideoVersionError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateVideoVersionError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateVideoVersionError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateVideoVersionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateVideoVersionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateVideoVersionErrorResponse : IErrorResponse<CreateVideoVersionError>
{
    public static CreateVideoVersionErrorResponse Instance { get; } = new();

    private CreateVideoVersionErrorResponse()
    {
    }

    public Task<CreateVideoVersionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateVideoVersionError.Create(response, ct);
}
