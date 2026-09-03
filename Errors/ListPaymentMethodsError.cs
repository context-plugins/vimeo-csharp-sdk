using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class ListPaymentMethodsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ListPaymentMethodsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ListPaymentMethodsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ListPaymentMethodsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ListPaymentMethodsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ListPaymentMethodsErrorResponse : IErrorResponse<ListPaymentMethodsError>
{
    public static ListPaymentMethodsErrorResponse Instance { get; } = new();

    private ListPaymentMethodsErrorResponse()
    {
    }

    public Task<ListPaymentMethodsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ListPaymentMethodsError.Create(response, ct);
}
