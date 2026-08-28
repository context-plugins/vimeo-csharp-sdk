using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditUserAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EditUserAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EditUserAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static EditUserAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EditUserAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditUserAlt1ErrorResponse : IErrorResponse<EditUserAlt1Error>
{
    public static EditUserAlt1ErrorResponse Instance { get; } = new();

    private EditUserAlt1ErrorResponse()
    {
    }

    public Task<EditUserAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditUserAlt1Error.Create(response, ct);
}
