using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetCategorySubscriptionsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetCategorySubscriptionsAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetCategorySubscriptionsAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetCategorySubscriptionsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetCategorySubscriptionsAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCategorySubscriptionsAlt1ErrorResponse : IErrorResponse<GetCategorySubscriptionsAlt1Error>
{
    public static GetCategorySubscriptionsAlt1ErrorResponse Instance { get; } = new();

    private GetCategorySubscriptionsAlt1ErrorResponse()
    {
    }

    public Task<GetCategorySubscriptionsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCategorySubscriptionsAlt1Error.Create(response, ct);
}
