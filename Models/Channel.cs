using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Channel
{
    /// <summary>
    /// The categories to which the channel belongs as specified by the channel moderators.
    /// </summary>
    [JsonPropertyName("categories")]
    public required IReadOnlyList<Category> Categories { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the channel was created.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// A brief explanation of the channel's content.
    /// </summary>
    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    /// <summary>
    /// The banner that appears by default at the top of the channel page.
    /// </summary>
    [JsonPropertyName("header")]
    public required Picture Header { get; init; }

    /// <summary>
    /// The URL to access the channel in a browser.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// Metadata about the channel.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata1 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the channel was last modified.
    /// </summary>
    [JsonPropertyName("modified_time")]
    public required string ModifiedTime { get; init; }

    /// <summary>
    /// The display name that identifies the channel.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The active image for the channel. The default is the thumbnail of the last video added to the channel.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture Pictures { get; init; }

    /// <summary>
    /// The privacy settings of the channel.
    /// </summary>
    [JsonPropertyName("privacy")]
    public required Privacy Privacy { get; init; }

    /// <summary>
    /// The channel resource key.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// An array of all tags assigned to the channel.
    /// </summary>
    [JsonPropertyName("tags")]
    public required IReadOnlyList<Tag> Tags { get; init; }

    /// <summary>
    /// The unique identifier to access the channel resource.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The Vimeo user who owns the channel.
    /// </summary>
    [JsonPropertyName("user")]
    public required User User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
