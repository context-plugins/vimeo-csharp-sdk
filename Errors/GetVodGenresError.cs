using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVodGenresError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetVodGenresError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetVodGenresError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetVodGenresError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetVodGenresError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodGenresErrorResponse : IErrorResponse<GetVodGenresError>
{
    public static GetVodGenresErrorResponse Instance { get; } = new();

    private GetVodGenresErrorResponse()
    {
    }

    public Task<GetVodGenresError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodGenresError.Create(response, ct);
}
