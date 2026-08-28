using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditUserError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EditUserError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EditUserError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static EditUserError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EditUserError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditUserErrorResponse : IErrorResponse<EditUserError>
{
    public static EditUserErrorResponse Instance { get; } = new();

    private EditUserErrorResponse()
    {
    }

    public Task<EditUserError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditUserError.Create(response, ct);
}
