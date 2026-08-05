using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeletePaymentMethodError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeletePaymentMethodError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeletePaymentMethodError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeletePaymentMethodError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeletePaymentMethodError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeletePaymentMethodErrorResponse : IErrorResponse<DeletePaymentMethodError>
{
    public static DeletePaymentMethodErrorResponse Instance { get; } = new();

    private DeletePaymentMethodErrorResponse()
    {
    }

    public Task<DeletePaymentMethodError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeletePaymentMethodError.Create(response, ct);
}
