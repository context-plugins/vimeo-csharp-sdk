using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class RemoveVideoFromProjectAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RemoveVideoFromProjectAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RemoveVideoFromProjectAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RemoveVideoFromProjectAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RemoveVideoFromProjectAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveVideoFromProjectAlt1ErrorResponse : IErrorResponse<RemoveVideoFromProjectAlt1Error>
{
    public static RemoveVideoFromProjectAlt1ErrorResponse Instance { get; } = new();

    private RemoveVideoFromProjectAlt1ErrorResponse()
    {
    }

    public Task<RemoveVideoFromProjectAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveVideoFromProjectAlt1Error.Create(response, ct);
}
