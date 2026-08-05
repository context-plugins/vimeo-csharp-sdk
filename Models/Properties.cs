using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// An object of suggested fields to be used for this interaction.
/// </summary>
public record Properties
{
    /// <summary>
    /// An object containing data on the value of <b>folder_uri</b> and whether it's required for the interaction.
    /// </summary>
    [JsonPropertyName("folder_uri")]
    public required FolderUri FolderUri { get; init; }

    /// <summary>
    /// An object containing data on the value of <b>status</b> and whether it's required for the interaction.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status3 Status { get; init; }

    /// <summary>
    /// An object containing data on the value of <b>upgrade_to_role</b> and whether it's required for the interaction.
    /// </summary>
    [JsonPropertyName("upgrade_to_role")]
    public required UpgradeToRole UpgradeToRole { get; init; }
}
