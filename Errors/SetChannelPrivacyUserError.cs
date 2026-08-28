using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class SetChannelPrivacyUserError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SetChannelPrivacyUserError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SetChannelPrivacyUserError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SetChannelPrivacyUserError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SetChannelPrivacyUserError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetChannelPrivacyUserErrorResponse : IErrorResponse<SetChannelPrivacyUserError>
{
    public static SetChannelPrivacyUserErrorResponse Instance { get; } = new();

    private SetChannelPrivacyUserErrorResponse()
    {
    }

    public Task<SetChannelPrivacyUserError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetChannelPrivacyUserError.Create(response, ct);
}
