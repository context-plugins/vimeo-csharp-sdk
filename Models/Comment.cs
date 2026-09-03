using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Comment
{
    /// <summary>
    /// The time in ISO 8601 format when the comment was posted.
    /// </summary>
    [JsonPropertyName("created_on")]
    public required string CreatedOn { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the comment was deleted.
    /// </summary>
    [JsonPropertyName("deleted_on")]
    public required string? DeletedOn { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the comment was last edited.
    /// </summary>
    [JsonPropertyName("last_edited_on")]
    public required string? LastEditedOn { get; init; }

    /// <summary>
    /// The permalink to the comment.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    [JsonPropertyName("metadata")]
    public required Metadata13 Metadata { get; init; }

    [JsonPropertyName("metdata")]
    public required Metdata Metdata { get; init; }

    /// <summary>
    /// The list of replies to the comment.
    /// </summary>
    [JsonPropertyName("replies")]
    public required IReadOnlyList<Reply> Replies { get; init; }

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
    /// The content of the comment.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    /// <summary>
    /// An array of text decorations for the note.
    /// </summary>
    [JsonPropertyName("text_decorations")]
    public required IReadOnlyList<TextDecoration> TextDecorations { get; init; }

    /// <summary>
    /// The Vimeo content to which the comment relates.
    /// <para>
    /// Option descriptions:
    ///  * <c>video</c> - The comment is about a video.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "video";

    /// <summary>
    /// The unique identifier to access the comment resource.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The user who posted the comment. _This field is deprecated. Use the <b>metadata.connections.user</b> field instead._
    /// </summary>
    [JsonPropertyName("user")]
    public required User? User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
