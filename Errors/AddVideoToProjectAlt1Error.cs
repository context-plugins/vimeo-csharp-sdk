using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AddVideoToProjectAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AddVideoToProjectAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AddVideoToProjectAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AddVideoToProjectAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AddVideoToProjectAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoToProjectAlt1ErrorResponse : IErrorResponse<AddVideoToProjectAlt1Error>
{
    public static AddVideoToProjectAlt1ErrorResponse Instance { get; } = new();

    private AddVideoToProjectAlt1ErrorResponse()
    {
    }

    public Task<AddVideoToProjectAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoToProjectAlt1Error.Create(response, ct);
}
