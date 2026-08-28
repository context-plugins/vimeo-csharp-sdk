using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteChannelCategoryError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteChannelCategoryError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteChannelCategoryError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static DeleteChannelCategoryError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static DeleteChannelCategoryError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteChannelCategoryError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 => FromJson<Error>(response, ct).As(AsError),
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteChannelCategoryErrorResponse : IErrorResponse<DeleteChannelCategoryError>
{
    public static DeleteChannelCategoryErrorResponse Instance { get; } = new();

    private DeleteChannelCategoryErrorResponse()
    {
    }

    public Task<DeleteChannelCategoryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteChannelCategoryError.Create(response, ct);
}
