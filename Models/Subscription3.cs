using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the authenticated user's Vimeo subscription.
/// </summary>
public record Subscription3
{
    /// <summary>
    /// Information about the authenticated user's subscription billing.
    /// </summary>
    [JsonPropertyName("billing")]
    public required Billing Billing { get; init; }

    /// <summary>
    /// Information about the authenticated user's next renewal.
    /// </summary>
    [JsonPropertyName("renewal")]
    public required Renewal Renewal { get; init; }

    /// <summary>
    /// Information about the authenticated user's trial.
    /// </summary>
    [JsonPropertyName("trial")]
    public required Trial Trial { get; init; }
}
