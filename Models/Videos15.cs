using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The additional videos that are offered after the main video ends.
/// </summary>
public record Videos15
{
    /// <summary>
    /// The source of the video collection that appears in the area for more videos.
    /// <para>
    /// Option descriptions:
    ///  * <c>album</c> - The video collection source is a user showcase.
    ///  * <c>all_videos</c> - The video collection source is all user videos.
    ///  * <c>channel</c> - The video collection source is a user channel.
    ///  * <c>group</c> - The video collection source is a user group.
    ///  * <c>likes</c> - The video collection source is user likes.
    ///  * <c>uploaded_videos</c> - The video collection source is user uploads.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outro_videos_collection_type")]
    public OutroVideosCollectionType? OutroVideosCollectionType { get; init; }

    /// <summary>
    /// The URI of the video collection that appears in the area for more videos when the value of <b>videos.outro_videos_collection_type</b> is <c>album</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outro_videos_collection_uri")]
    public string? OutroVideosCollectionUri { get; init; }

    /// <summary>
    /// The background image to display in the area for more videos.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("picture")]
    public Picture? Picture { get; init; }

    /// <summary>
    /// The URI of the background image that appears in the area for more videos.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("picture_uri")]
    public string? PictureUri { get; init; }

    /// <summary>
    /// The URIs of the videos when the value of <b>videos.outro_videos_collection_type</b> is <c>uploaded_videos</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("video_uris")]
    public IReadOnlyList<string>? VideoUris { get; init; }
}
