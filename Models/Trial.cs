using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// Information about the authenticated user's trial.
/// </summary>
public record Trial
{
    /// <summary>
    /// Whether the authenticated user has been in (or is currently in) a free trial. The user might not be eligible for a free trial even when the value of this field is <c>false</c>.
    /// </summary>
    [JsonPropertyName("has_been_in_free_trial")]
    public required bool HasBeenInFreeTrial { get; init; }

    /// <summary>
    /// Whether the user is currently in a Reverse free trial. Reverse trials are no-card trials granted before purchase and have no PaymentsService subscription backing them; for these users, <c>subscription.renewal.renewal_date</c> carries the trial-expiry datetime instead of a next-charge datetime.
    /// </summary>
    [JsonPropertyName("is_reverse_free_trial")]
    public required bool IsReverseFreeTrial { get; init; }

    /// <summary>
    /// The status of the authenticated user's trial.
    /// <para>
    /// Option descriptions:
    ///  * <c>free_trial</c> - The user is currently in a free trial.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status1? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
