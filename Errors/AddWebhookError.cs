using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AddWebhookError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AddWebhookError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AddWebhookError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static AddWebhookError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AddWebhookError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddWebhookErrorResponse : IErrorResponse<AddWebhookError>
{
    public static AddWebhookErrorResponse Instance { get; } = new();

    private AddWebhookErrorResponse()
    {
    }

    public Task<AddWebhookError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddWebhookError.Create(response, ct);
}
