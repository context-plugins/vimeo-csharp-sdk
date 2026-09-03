using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class UpdateWebhookError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private UpdateWebhookError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static UpdateWebhookError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static UpdateWebhookError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<UpdateWebhookError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateWebhookErrorResponse : IErrorResponse<UpdateWebhookError>
{
    public static UpdateWebhookErrorResponse Instance { get; } = new();

    private UpdateWebhookErrorResponse()
    {
    }

    public Task<UpdateWebhookError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateWebhookError.Create(response, ct);
}
