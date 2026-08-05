using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetAvailableVideoShowcasesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAvailableVideoShowcasesError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAvailableVideoShowcasesError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAvailableVideoShowcasesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAvailableVideoShowcasesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAvailableVideoShowcasesErrorResponse : IErrorResponse<GetAvailableVideoShowcasesError>
{
    public static GetAvailableVideoShowcasesErrorResponse Instance { get; } = new();

    private GetAvailableVideoShowcasesErrorResponse()
    {
    }

    public Task<GetAvailableVideoShowcasesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAvailableVideoShowcasesError.Create(response, ct);
}
