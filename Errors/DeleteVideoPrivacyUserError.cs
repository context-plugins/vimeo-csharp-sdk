using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteVideoPrivacyUserError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVideoPrivacyUserError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVideoPrivacyUserError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVideoPrivacyUserError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVideoPrivacyUserError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVideoPrivacyUserErrorResponse : IErrorResponse<DeleteVideoPrivacyUserError>
{
    public static DeleteVideoPrivacyUserErrorResponse Instance { get; } = new();

    private DeleteVideoPrivacyUserErrorResponse()
    {
    }

    public Task<DeleteVideoPrivacyUserError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVideoPrivacyUserError.Create(response, ct);
}
