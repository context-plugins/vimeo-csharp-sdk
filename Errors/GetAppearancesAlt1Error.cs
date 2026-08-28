using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetAppearancesAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAppearancesAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAppearancesAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAppearancesAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAppearancesAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAppearancesAlt1ErrorResponse : IErrorResponse<GetAppearancesAlt1Error>
{
    public static GetAppearancesAlt1ErrorResponse Instance { get; } = new();

    private GetAppearancesAlt1ErrorResponse()
    {
    }

    public Task<GetAppearancesAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAppearancesAlt1Error.Create(response, ct);
}
