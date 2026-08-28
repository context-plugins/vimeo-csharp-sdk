using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Group
{
    /// <summary>
    /// The time in ISO 8601 format when the group was created.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// The group's description.
    /// </summary>
    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    /// <summary>
    /// The link to the group.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// Metadata about the group.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata6 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the group was last modified.
    /// </summary>
    [JsonPropertyName("modified_time")]
    public required string ModifiedTime { get; init; }

    /// <summary>
    /// The group's display name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The active picture for the group.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture Pictures { get; init; }

    /// <summary>
    /// The group's privacy settings.
    /// </summary>
    [JsonPropertyName("privacy")]
    public required Privacy4 Privacy { get; init; }

    /// <summary>
    /// The resource key of the group.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// The canonical relative URI of the group.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The owner of the group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public User? User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
