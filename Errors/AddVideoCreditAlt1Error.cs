using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AddVideoCreditAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideoCreditAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideoCreditAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideoCreditAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideoCreditAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoCreditAlt1ErrorResponse : IErrorResponse<AddVideoCreditAlt1Error>
{
    public static AddVideoCreditAlt1ErrorResponse Instance { get; } = new();

    private AddVideoCreditAlt1ErrorResponse()
    {
    }

    public Task<AddVideoCreditAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoCreditAlt1Error.Create(response, ct);
}
