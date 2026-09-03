using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetCategoryError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetCategoryError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetCategoryError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetCategoryError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetCategoryError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCategoryErrorResponse : IErrorResponse<GetCategoryError>
{
    public static GetCategoryErrorResponse Instance { get; } = new();

    private GetCategoryErrorResponse()
    {
    }

    public Task<GetCategoryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCategoryError.Create(response, ct);
}
