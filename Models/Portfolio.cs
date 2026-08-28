using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Portfolio
{
    /// <summary>
    /// The time in ISO 8601 format when the portfolio was created.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// The description of the portfolio.
    /// </summary>
    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    /// <summary>
    /// The link to the portfolio.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// Metadata about the portfolio.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata22 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the portfolio's data was last modified.
    /// </summary>
    [JsonPropertyName("modified_time")]
    public required string ModifiedTime { get; init; }

    /// <summary>
    /// The display name of the portfolio.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The default video sort order of the portfolio.
    /// <para>
    /// Option descriptions:
    ///  * <c>alphabetical</c> - The default sort order is alphabetical by name.
    ///  * <c>clips</c> - The default sort order is video creation date.
    ///  * <c>modified</c> - The default sort order is the order in which the videos were modified.
    ///  * <c>recent</c> - The default sort order is the order in which the videos were added.
    /// </para>
    /// </summary>
    [JsonPropertyName("sort")]
    public required Sort1 Sort { get; init; }

    /// <summary>
    /// The canonical relative URI of the portfolio.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
