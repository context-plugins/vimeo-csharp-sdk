using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetChannelSubscriptionsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetChannelSubscriptionsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetChannelSubscriptionsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetChannelSubscriptionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetChannelSubscriptionsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChannelSubscriptionsErrorResponse : IErrorResponse<GetChannelSubscriptionsError>
{
    public static GetChannelSubscriptionsErrorResponse Instance { get; } = new();

    private GetChannelSubscriptionsErrorResponse()
    {
    }

    public Task<GetChannelSubscriptionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChannelSubscriptionsError.Create(response, ct);
}
