using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Preset
{
    /// <summary>
    /// The time in ISO 8601 format when the preset was created.
    /// </summary>
    [JsonPropertyName("created_on")]
    public required string CreatedOn { get; init; }

    /// <summary>
    /// Metadata about the preset.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata23 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the preset was last modified.
    /// </summary>
    [JsonPropertyName("modified_on")]
    public required string ModifiedOn { get; init; }

    /// <summary>
    /// The display name of the preset group.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The contents of the preset group.
    /// </summary>
    [JsonPropertyName("settings")]
    public required Settings1 Settings { get; init; }

    /// <summary>
    /// The canonical relative URI of the preset object.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The owner of the preset.
    /// </summary>
    [JsonPropertyName("user")]
    public required User? User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
