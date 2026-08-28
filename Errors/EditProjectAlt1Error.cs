using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditProjectAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EditProjectAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EditProjectAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static EditProjectAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EditProjectAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditProjectAlt1ErrorResponse : IErrorResponse<EditProjectAlt1Error>
{
    public static EditProjectAlt1ErrorResponse Instance { get; } = new();

    private EditProjectAlt1ErrorResponse()
    {
    }

    public Task<EditProjectAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditProjectAlt1Error.Create(response, ct);
}
