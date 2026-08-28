using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// An object containing data on the value of <b>folder_uri</b> and whether it's required for the interaction.
/// </summary>
public record FolderUri
{
    /// <summary>
    /// Whether the URI of the folder must be sent to achieve the desired action.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; init; }

    /// <summary>
    /// The URI of the folder to which the team member should have access.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
