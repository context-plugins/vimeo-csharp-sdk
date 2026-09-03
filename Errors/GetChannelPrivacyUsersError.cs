using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetChannelPrivacyUsersError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetChannelPrivacyUsersError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetChannelPrivacyUsersError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetChannelPrivacyUsersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetChannelPrivacyUsersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChannelPrivacyUsersErrorResponse : IErrorResponse<GetChannelPrivacyUsersError>
{
    public static GetChannelPrivacyUsersErrorResponse Instance { get; } = new();

    private GetChannelPrivacyUsersErrorResponse()
    {
    }

    public Task<GetChannelPrivacyUsersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChannelPrivacyUsersError.Create(response, ct);
}
