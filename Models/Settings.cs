using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The settings of the folder.
/// </summary>
public record Settings
{
    /// <summary>
    /// The hexadecimal color code of the folder color.
    /// </summary>
    [JsonPropertyName("color")]
    public required string Color { get; init; }

    /// <summary>
    /// The ID of the embed preset for the folder.
    /// </summary>
    [JsonPropertyName("embed_preset_id")]
    public required double? EmbedPresetId { get; init; }

    /// <summary>
    /// The URI of the folder.
    /// </summary>
    [JsonPropertyName("folder_uri")]
    public required string? FolderUri { get; init; }

    /// <summary>
    /// Whether embed preset inheritance is enabled for the folder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_embed_preset_inheritance_enabled")]
    public bool? IsEmbedPresetInheritanceEnabled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
