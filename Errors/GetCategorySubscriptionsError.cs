using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetCategorySubscriptionsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetCategorySubscriptionsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetCategorySubscriptionsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetCategorySubscriptionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetCategorySubscriptionsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCategorySubscriptionsErrorResponse : IErrorResponse<GetCategorySubscriptionsError>
{
    public static GetCategorySubscriptionsErrorResponse Instance { get; } = new();

    private GetCategorySubscriptionsErrorResponse()
    {
    }

    public Task<GetCategorySubscriptionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCategorySubscriptionsError.Create(response, ct);
}
