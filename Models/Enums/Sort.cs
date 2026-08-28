using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The sort order of the showcase.
/// <para>
/// Option descriptions:
///  * <c>added_first</c> - Sort the showcase videos in order of those most recently added.
///  * <c>added_last</c> - Sort the showcase videos in order of those least recently added.
///  * <c>alphabetical</c> - Sort the showcase videos alphabetically.
///  * <c>arranged</c> - Sort the showcase videos according to their custom arrangement.
///  * <c>comments</c> - Sort the showcase videos by number of comments.
///  * <c>likes</c> - Sort the showcase videos by number of likes.
///  * <c>newest</c> - Sort the showcase videos in order of creation date with the newest first.
///  * <c>oldest</c> - Sort the showcase videos in order of creation date with the oldest first.
///  * <c>plays</c> - Sort the showcase videos by number of plays.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Sort>))]
public sealed record Sort : StringEnum<Sort>
{
    private Sort(string value) : base(value)
    {
    }

    public static readonly Sort AddedFirst = new("added_first");

    public static readonly Sort AddedLast = new("added_last");

    public static readonly Sort Alphabetical = new("alphabetical");

    public static readonly Sort Arranged = new("arranged");

    public static readonly Sort Comments = new("comments");

    public static readonly Sort Likes = new("likes");

    public static readonly Sort Newest = new("newest");

    public static readonly Sort Oldest = new("oldest");

    public static readonly Sort Plays = new("plays");

    public static Sort FromValue(string value) => FromValueCore(value);
}
