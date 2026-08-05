using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetAppearancesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAppearancesError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAppearancesError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetAppearancesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAppearancesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAppearancesErrorResponse : IErrorResponse<GetAppearancesError>
{
    public static GetAppearancesErrorResponse Instance { get; } = new();

    private GetAppearancesErrorResponse()
    {
    }

    public Task<GetAppearancesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAppearancesError.Create(response, ct);
}
