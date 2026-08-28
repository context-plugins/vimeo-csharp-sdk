using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about the authenticated user's next renewal.
/// </summary>
public record Renewal
{
    /// <summary>
    /// The date in YYYY-MM-DD format when the authenticated user's membership renews (or expires, if they have disabled automatic renewal, or the trial ends without renewal in case of a Reverse trial). This value is for display only; the exact time at which renewal or expiration occurs on this date isn't guaranteed.
    /// </summary>
    [JsonPropertyName("display_date")]
    public required string DisplayDate { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
