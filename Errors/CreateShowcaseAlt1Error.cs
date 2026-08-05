using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CreateShowcaseAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateShowcaseAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateShowcaseAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateShowcaseAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateShowcaseAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateShowcaseAlt1ErrorResponse : IErrorResponse<CreateShowcaseAlt1Error>
{
    public static CreateShowcaseAlt1ErrorResponse Instance { get; } = new();

    private CreateShowcaseAlt1ErrorResponse()
    {
    }

    public Task<CreateShowcaseAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateShowcaseAlt1Error.Create(response, ct);
}
