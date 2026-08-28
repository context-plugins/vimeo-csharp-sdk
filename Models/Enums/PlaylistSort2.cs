using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The order in which the videos of the event appear within the event's playlist.
/// <para>
/// Option descriptions:
///  * <c>added_first</c> - The most recently added videos appear first.
///  * <c>added_last</c> - The most recently added videos appear last.
///  * <c>alphabetical</c> - The videos appear in alphabetical order.
///  * <c>arranged</c> - The videos appear in the order in which the user has arranged them.
///  * <c>comments</c> - The videos appear in order of number of comments.
///  * <c>duration</c> - The videos appear in order of duration.
///  * <c>likes</c> - The videos appear in order of number of likes.
///  * <c>newest</c> - The newest videos appear first.
///  * <c>oldest</c> - The oldest videos appear first.
///  * <c>plays</c> - The videos appear in order of number of plays.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlaylistSort2>))]
public sealed record PlaylistSort2 : StringEnum<PlaylistSort2>
{
    private PlaylistSort2(string value) : base(value)
    {
    }

    public static readonly PlaylistSort2 AddedFirst = new("added_first");

    public static readonly PlaylistSort2 AddedLast = new("added_last");

    public static readonly PlaylistSort2 Alphabetical = new("alphabetical");

    public static readonly PlaylistSort2 Arranged = new("arranged");

    public static readonly PlaylistSort2 Comments = new("comments");

    public static readonly PlaylistSort2 Duration = new("duration");

    public static readonly PlaylistSort2 Likes = new("likes");

    public static readonly PlaylistSort2 Newest = new("newest");

    public static readonly PlaylistSort2 Oldest = new("oldest");

    public static readonly PlaylistSort2 Plays = new("plays");

    public static PlaylistSort2 FromValue(string value) => FromValueCore(value);
}
