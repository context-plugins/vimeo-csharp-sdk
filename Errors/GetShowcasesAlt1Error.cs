using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetShowcasesAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetShowcasesAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetShowcasesAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetShowcasesAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetShowcasesAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetShowcasesAlt1ErrorResponse : IErrorResponse<GetShowcasesAlt1Error>
{
    public static GetShowcasesAlt1ErrorResponse Instance { get; } = new();

    private GetShowcasesAlt1ErrorResponse()
    {
    }

    public Task<GetShowcasesAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetShowcasesAlt1Error.Create(response, ct);
}
