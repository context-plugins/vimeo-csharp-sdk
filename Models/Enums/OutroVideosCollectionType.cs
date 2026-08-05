using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<OutroVideosCollectionType>))]
public sealed record OutroVideosCollectionType : StringEnum<OutroVideosCollectionType>
{
    private OutroVideosCollectionType(string value) : base(value)
    {
    }

    public static readonly OutroVideosCollectionType Album = new("album");

    public static readonly OutroVideosCollectionType AllVideos = new("all_videos");

    public static readonly OutroVideosCollectionType Channel = new("channel");

    public static readonly OutroVideosCollectionType Group = new("group");

    public static readonly OutroVideosCollectionType Likes = new("likes");

    public static readonly OutroVideosCollectionType UploadedVideos = new("uploaded_videos");

    public static OutroVideosCollectionType FromValue(string value) => FromValueCore(value);
}
