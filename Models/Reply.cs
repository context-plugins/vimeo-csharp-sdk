using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Reply
{
    /// <summary>
    /// The time in ISO 8601 format when the reply was posted.
    /// </summary>
    [JsonPropertyName("created_on")]
    public required string CreatedOn { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the reply was deleted.
    /// </summary>
    [JsonPropertyName("deleted_on")]
    public required string? DeletedOn { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the reply was last edited.
    /// </summary>
    [JsonPropertyName("last_edited_on")]
    public required string? LastEditedOn { get; init; }

    /// <summary>
    /// The permalink to the reply.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    [JsonPropertyName("metadata")]
    public required Metadata14 Metadata { get; init; }

    /// <summary>
    /// The comment's resource key string.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// The stringified Rich Text JSON.
    /// </summary>
    [JsonPropertyName("richtext")]
    public required string? Richtext { get; init; }

    /// <summary>
    /// The content of the reply.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    /// <summary>
    /// An array of text decorations for the note.
    /// </summary>
    [JsonPropertyName("text_decorations")]
    public required IReadOnlyList<TextDecoration> TextDecorations { get; init; }

    /// <summary>
    /// The Vimeo content to which the reply relates.
    /// <para>
    /// Option descriptions:
    ///  * <c>video</c> - The comment is about a video.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type13 Type { get; init; }

    /// <summary>
    /// The unique identifier to access the reply resource.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
