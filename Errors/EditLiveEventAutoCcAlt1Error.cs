using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditLiveEventAutoCcAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EditLiveEventAutoCcAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EditLiveEventAutoCcAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EditLiveEventAutoCcAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EditLiveEventAutoCcAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditLiveEventAutoCcAlt1ErrorResponse : IErrorResponse<EditLiveEventAutoCcAlt1Error>
{
    public static EditLiveEventAutoCcAlt1ErrorResponse Instance { get; } = new();

    private EditLiveEventAutoCcAlt1ErrorResponse()
    {
    }

    public Task<EditLiveEventAutoCcAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditLiveEventAutoCcAlt1Error.Create(response, ct);
}
