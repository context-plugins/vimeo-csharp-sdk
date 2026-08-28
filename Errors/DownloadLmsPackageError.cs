using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;

namespace Vimeo.Errors;

public sealed class DownloadLmsPackageError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DownloadLmsPackageError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DownloadLmsPackageError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static DownloadLmsPackageError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<DownloadLmsPackageError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 or 500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DownloadLmsPackageErrorResponse : IErrorResponse<DownloadLmsPackageError>
{
    public static DownloadLmsPackageErrorResponse Instance { get; } = new();

    private DownloadLmsPackageErrorResponse()
    {
    }

    public Task<DownloadLmsPackageError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DownloadLmsPackageError.Create(response, ct);
}
