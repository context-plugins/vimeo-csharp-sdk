using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetShowcasesError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetShowcasesError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetShowcasesError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetShowcasesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetShowcasesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetShowcasesErrorResponse : IErrorResponse<GetShowcasesError>
{
    public static GetShowcasesErrorResponse Instance { get; } = new();

    private GetShowcasesErrorResponse()
    {
    }

    public Task<GetShowcasesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetShowcasesError.Create(response, ct);
}
