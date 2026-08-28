using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record AnimatedThumbset
{
    /// <summary>
    /// The URI of the video from which the sets of animated thumbnails were created.
    /// </summary>
    [JsonPropertyName("clip_uri")]
    public required string ClipUri { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the GIF was created.
    /// </summary>
    [JsonPropertyName("created_on")]
    public required string CreatedOn { get; init; }

    /// <summary>
    /// An array of all the animated thumbnails in the set.
    /// </summary>
    [JsonPropertyName("sizes")]
    public required IReadOnlyList<AnimatedThumbnail> Sizes { get; init; }

    /// <summary>
    /// The availability of the animated thumbnail.
    /// <para>
    /// Option descriptions:
    ///  * <c>cancelled</c> - The animated thumbnail's creation has been cancelled.
    ///  * <c>completed</c> - The animated thumbnail has been created.
    ///  * <c>failed</c> - The animated thumbnail's creation has failed.
    ///  * <c>started</c> - The animated thumbnail's creation has started.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status10 Status { get; init; }

    /// <summary>
    /// The URI of the set of animated thumbnails.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
