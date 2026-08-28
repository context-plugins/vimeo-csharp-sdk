using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVodPosterError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVodPosterError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVodPosterError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVodPosterError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVodPosterError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVodPosterErrorResponse : IErrorResponse<AddVodPosterError>
{
    public static AddVodPosterErrorResponse Instance { get; } = new();

    private AddVodPosterErrorResponse()
    {
    }

    public Task<AddVodPosterError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVodPosterError.Create(response, ct);
}
