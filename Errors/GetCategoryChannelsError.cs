using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetCategoryChannelsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetCategoryChannelsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetCategoryChannelsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetCategoryChannelsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetCategoryChannelsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCategoryChannelsErrorResponse : IErrorResponse<GetCategoryChannelsError>
{
    public static GetCategoryChannelsErrorResponse Instance { get; } = new();

    private GetCategoryChannelsErrorResponse()
    {
    }

    public Task<GetCategoryChannelsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCategoryChannelsError.Create(response, ct);
}
