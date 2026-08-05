using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// An object containing data on the value of <b>upgrade_to_role</b> and whether it's required for the interaction.
/// </summary>
public record UpgradeToRole
{
    /// <summary>
    /// Whether the upgrade role must be sent to achieve the desired action.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; init; }

    /// <summary>
    /// The value of the team role to which the user should be upgraded.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; init; }
}
