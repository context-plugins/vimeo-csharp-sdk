using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class FederatedSearchUserItemsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FederatedSearchUserItemsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FederatedSearchUserItemsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static FederatedSearchUserItemsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FederatedSearchUserItemsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FederatedSearchUserItemsErrorResponse : IErrorResponse<FederatedSearchUserItemsError>
{
    public static FederatedSearchUserItemsErrorResponse Instance { get; } = new();

    private FederatedSearchUserItemsErrorResponse()
    {
    }

    public Task<FederatedSearchUserItemsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        FederatedSearchUserItemsError.Create(response, ct);
}
