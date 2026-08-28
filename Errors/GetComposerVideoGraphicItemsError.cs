using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetComposerVideoGraphicItemsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetComposerVideoGraphicItemsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetComposerVideoGraphicItemsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetComposerVideoGraphicItemsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetComposerVideoGraphicItemsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetComposerVideoGraphicItemsErrorResponse : IErrorResponse<GetComposerVideoGraphicItemsError>
{
    public static GetComposerVideoGraphicItemsErrorResponse Instance { get; } = new();

    private GetComposerVideoGraphicItemsErrorResponse()
    {
    }

    public Task<GetComposerVideoGraphicItemsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetComposerVideoGraphicItemsError.Create(response, ct);
}
