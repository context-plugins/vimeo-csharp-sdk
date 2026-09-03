using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetChannelCategoriesError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetChannelCategoriesError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetChannelCategoriesError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetChannelCategoriesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetChannelCategoriesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChannelCategoriesErrorResponse : IErrorResponse<GetChannelCategoriesError>
{
    public static GetChannelCategoriesErrorResponse Instance { get; } = new();

    private GetChannelCategoriesErrorResponse()
    {
    }

    public Task<GetChannelCategoriesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChannelCategoriesError.Create(response, ct);
}
