using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVideoReportingReasonsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetVideoReportingReasonsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetVideoReportingReasonsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetVideoReportingReasonsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetVideoReportingReasonsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVideoReportingReasonsErrorResponse : IErrorResponse<GetVideoReportingReasonsError>
{
    public static GetVideoReportingReasonsErrorResponse Instance { get; } = new();

    private GetVideoReportingReasonsErrorResponse()
    {
    }

    public Task<GetVideoReportingReasonsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVideoReportingReasonsError.Create(response, ct);
}
