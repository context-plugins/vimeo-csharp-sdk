using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideoCreditError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideoCreditError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideoCreditError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideoCreditError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideoCreditError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoCreditErrorResponse : IErrorResponse<AddVideoCreditError>
{
    public static AddVideoCreditErrorResponse Instance { get; } = new();

    private AddVideoCreditErrorResponse()
    {
    }

    public Task<AddVideoCreditError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoCreditError.Create(response, ct);
}
