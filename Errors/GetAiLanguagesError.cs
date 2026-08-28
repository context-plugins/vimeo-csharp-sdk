using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetAiLanguagesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAiLanguagesError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAiLanguagesError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetAiLanguagesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAiLanguagesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAiLanguagesErrorResponse : IErrorResponse<GetAiLanguagesError>
{
    public static GetAiLanguagesErrorResponse Instance { get; } = new();

    private GetAiLanguagesErrorResponse()
    {
    }

    public Task<GetAiLanguagesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAiLanguagesError.Create(response, ct);
}
