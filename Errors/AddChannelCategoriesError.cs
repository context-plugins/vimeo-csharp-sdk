using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AddChannelCategoriesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddChannelCategoriesError(Optional<Error> errorValue,
        Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddChannelCategoriesError AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static AddChannelCategoriesError AsLegacyError(LegacyError value) =>
        new(default, Optional<LegacyError>.Some(value), default);

    private static AddChannelCategoriesError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddChannelCategoriesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 => FromJson<Error>(response, ct).As(AsError),
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddChannelCategoriesErrorResponse : IErrorResponse<AddChannelCategoriesError>
{
    public static AddChannelCategoriesErrorResponse Instance { get; } = new();

    private AddChannelCategoriesErrorResponse()
    {
    }

    public Task<AddChannelCategoriesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddChannelCategoriesError.Create(response, ct);
}
