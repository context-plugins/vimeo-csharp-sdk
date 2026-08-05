using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AddFolderToShowcasesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AddFolderToShowcasesError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AddFolderToShowcasesError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AddFolderToShowcasesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AddFolderToShowcasesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddFolderToShowcasesErrorResponse : IErrorResponse<AddFolderToShowcasesError>
{
    public static AddFolderToShowcasesErrorResponse Instance { get; } = new();

    private AddFolderToShowcasesErrorResponse()
    {
    }

    public Task<AddFolderToShowcasesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddFolderToShowcasesError.Create(response, ct);
}
