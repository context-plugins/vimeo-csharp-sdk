using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// Team seats entitlement information.
/// </summary>
public record Seats
{
    /// <summary>
    /// The number of admin team seats included with the tier.
    /// </summary>
    [JsonPropertyName("admin")]
    public required double? Admin { get; init; }

    /// <summary>
    /// The number of authenticated team seats included with the tier.
    /// </summary>
    [JsonPropertyName("authenticated")]
    public required double? Authenticated { get; init; }

    /// <summary>
    /// The team seats mode for the user's team.
    /// <para>
    /// Option descriptions:
    ///  * <c>admin_and_authenticated</c> - The mode for Enterprise-Base Platform, Enterprise-Marketing, and Enterprise-Central users.
    ///  * <c>global</c> - The default mode for legacy and self-serve users.
    ///  * <c>per_seat_type</c> - The mode for sales-assisted users, including Enterprise, Custom, and Custom OTT.
    /// </para>
    /// </summary>
    [JsonPropertyName("mode")]
    public required Mode Mode { get; init; }

    /// <summary>
    /// The number of team seats included with the tier for the monthly plan.
    /// </summary>
    [JsonPropertyName("team")]
    public required double? Team { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
