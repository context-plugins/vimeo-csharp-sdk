using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetPaymentMethodInfoError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetPaymentMethodInfoError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetPaymentMethodInfoError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetPaymentMethodInfoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetPaymentMethodInfoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetPaymentMethodInfoErrorResponse : IErrorResponse<GetPaymentMethodInfoError>
{
    public static GetPaymentMethodInfoErrorResponse Instance { get; } = new();

    private GetPaymentMethodInfoErrorResponse()
    {
    }

    public Task<GetPaymentMethodInfoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetPaymentMethodInfoError.Create(response, ct);
}
