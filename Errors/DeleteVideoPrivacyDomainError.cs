using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteVideoPrivacyDomainError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVideoPrivacyDomainError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVideoPrivacyDomainError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVideoPrivacyDomainError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVideoPrivacyDomainError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVideoPrivacyDomainErrorResponse : IErrorResponse<DeleteVideoPrivacyDomainError>
{
    public static DeleteVideoPrivacyDomainErrorResponse Instance { get; } = new();

    private DeleteVideoPrivacyDomainErrorResponse()
    {
    }

    public Task<DeleteVideoPrivacyDomainError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVideoPrivacyDomainError.Create(response, ct);
}
