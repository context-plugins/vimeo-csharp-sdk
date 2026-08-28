using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class FederatedSearchUserItemsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FederatedSearchUserItemsAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FederatedSearchUserItemsAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FederatedSearchUserItemsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FederatedSearchUserItemsAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FederatedSearchUserItemsAlt1ErrorResponse : IErrorResponse<FederatedSearchUserItemsAlt1Error>
{
    public static FederatedSearchUserItemsAlt1ErrorResponse Instance { get; } = new();

    private FederatedSearchUserItemsAlt1ErrorResponse()
    {
    }

    public Task<FederatedSearchUserItemsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        FederatedSearchUserItemsAlt1Error.Create(response, ct);
}
