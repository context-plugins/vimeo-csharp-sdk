using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetChannelSubscriptionsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetChannelSubscriptionsAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetChannelSubscriptionsAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetChannelSubscriptionsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetChannelSubscriptionsAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChannelSubscriptionsAlt1ErrorResponse : IErrorResponse<GetChannelSubscriptionsAlt1Error>
{
    public static GetChannelSubscriptionsAlt1ErrorResponse Instance { get; } = new();

    private GetChannelSubscriptionsAlt1ErrorResponse()
    {
    }

    public Task<GetChannelSubscriptionsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChannelSubscriptionsAlt1Error.Create(response, ct);
}
