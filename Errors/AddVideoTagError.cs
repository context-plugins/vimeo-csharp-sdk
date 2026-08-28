using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideoTagError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideoTagError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideoTagError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideoTagError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideoTagError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoTagErrorResponse : IErrorResponse<AddVideoTagError>
{
    public static AddVideoTagErrorResponse Instance { get; } = new();

    private AddVideoTagErrorResponse()
    {
    }

    public Task<AddVideoTagError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoTagError.Create(response, ct);
}
