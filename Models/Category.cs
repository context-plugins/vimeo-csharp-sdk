using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Category
{
    /// <summary>
    /// The active icon for the category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("icon")]
    public Picture? Icon { get; init; }

    /// <summary>
    /// Whether the category is deprecated and should not be used for new categorization.
    /// </summary>
    [JsonPropertyName("is_deprecated")]
    public required bool IsDeprecated { get; init; }

    /// <summary>
    /// The most recent time in ISO 8601 format when the video was featured.
    /// </summary>
    [JsonPropertyName("last_video_featured_time")]
    public required string LastVideoFeaturedTime { get; init; }

    /// <summary>
    /// The URL to access the category in a browser.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// Metadata about the category.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata Metadata { get; init; }

    /// <summary>
    /// The display name that identifies the category.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The container of the category's parent category, if the current category is a subcategory.
    /// </summary>
    [JsonPropertyName("parent")]
    public required Parent? Parent { get; init; }

    /// <summary>
    /// The active picture for this category. The default shows vertical color bars.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture Pictures { get; init; }

    /// <summary>
    /// The resource key of the category.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// All the subcategories that belong to the category, if the current category is a top-level parent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subcategories")]
    public IReadOnlyList<Subcategory>? Subcategories { get; init; }

    /// <summary>
    /// Whether the category isn't a subcategory of another category.
    /// </summary>
    [JsonPropertyName("top_level")]
    public required bool TopLevel { get; init; }

    /// <summary>
    /// The unique identifier to access the category resource.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}
