using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class ExportVpaasViewerAnalyticsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ExportVpaasViewerAnalyticsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ExportVpaasViewerAnalyticsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ExportVpaasViewerAnalyticsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ExportVpaasViewerAnalyticsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ExportVpaasViewerAnalyticsErrorResponse : IErrorResponse<ExportVpaasViewerAnalyticsError>
{
    public static ExportVpaasViewerAnalyticsErrorResponse Instance { get; } = new();

    private ExportVpaasViewerAnalyticsErrorResponse()
    {
    }

    public Task<ExportVpaasViewerAnalyticsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ExportVpaasViewerAnalyticsError.Create(response, ct);
}
