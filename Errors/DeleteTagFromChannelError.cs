using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteTagFromChannelError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private readonly Optional<Error> _errorValue;

    private DeleteTagFromChannelError(Optional<LegacyError> legacyErrorValue,
        Optional<Error> errorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
        _errorValue = errorValue;
    }

    private static DeleteTagFromChannelError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default, default);

    private static DeleteTagFromChannelError AsError(Error value) =>
        new(default, Optional<Error>.Some(value), default);

    private static DeleteTagFromChannelError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteTagFromChannelError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteTagFromChannelErrorResponse : IErrorResponse<DeleteTagFromChannelError>
{
    public static DeleteTagFromChannelErrorResponse Instance { get; } = new();

    private DeleteTagFromChannelErrorResponse()
    {
    }

    public Task<DeleteTagFromChannelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteTagFromChannelError.Create(response, ct);
}
