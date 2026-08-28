using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditLiveEventAutoCcError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EditLiveEventAutoCcError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EditLiveEventAutoCcError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EditLiveEventAutoCcError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EditLiveEventAutoCcError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditLiveEventAutoCcErrorResponse : IErrorResponse<EditLiveEventAutoCcError>
{
    public static EditLiveEventAutoCcErrorResponse Instance { get; } = new();

    private EditLiveEventAutoCcErrorResponse()
    {
    }

    public Task<EditLiveEventAutoCcError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditLiveEventAutoCcError.Create(response, ct);
}
