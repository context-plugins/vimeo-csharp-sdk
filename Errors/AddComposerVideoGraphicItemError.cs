using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AddComposerVideoGraphicItemError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AddComposerVideoGraphicItemError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AddComposerVideoGraphicItemError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AddComposerVideoGraphicItemError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AddComposerVideoGraphicItemError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddComposerVideoGraphicItemErrorResponse : IErrorResponse<AddComposerVideoGraphicItemError>
{
    public static AddComposerVideoGraphicItemErrorResponse Instance { get; } = new();

    private AddComposerVideoGraphicItemErrorResponse()
    {
    }

    public Task<AddComposerVideoGraphicItemError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddComposerVideoGraphicItemError.Create(response, ct);
}
