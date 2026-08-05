using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteWebhookError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteWebhookError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteWebhookError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteWebhookError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteWebhookError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteWebhookErrorResponse : IErrorResponse<DeleteWebhookError>
{
    public static DeleteWebhookErrorResponse Instance { get; } = new();

    private DeleteWebhookErrorResponse()
    {
    }

    public Task<DeleteWebhookError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteWebhookError.Create(response, ct);
}
