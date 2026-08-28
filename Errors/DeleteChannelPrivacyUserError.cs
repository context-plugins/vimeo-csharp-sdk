using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteChannelPrivacyUserError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteChannelPrivacyUserError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteChannelPrivacyUserError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteChannelPrivacyUserError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteChannelPrivacyUserError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteChannelPrivacyUserErrorResponse : IErrorResponse<DeleteChannelPrivacyUserError>
{
    public static DeleteChannelPrivacyUserErrorResponse Instance { get; } = new();

    private DeleteChannelPrivacyUserErrorResponse()
    {
    }

    public Task<DeleteChannelPrivacyUserError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteChannelPrivacyUserError.Create(response, ct);
}
