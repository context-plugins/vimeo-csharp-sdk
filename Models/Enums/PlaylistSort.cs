using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The order in which the videos inside the event appear in the playlist.
/// <para>
/// Option descriptions:
///  * <c>added_first</c> - The videos appear according to when they were added to the event, with the most recently added first.
///  * <c>added_last</c> - The videos appear according to when they were added to the event, with the most recently added last.
///  * <c>alphabetical</c> - The videos appear alphabetically by their title.
///  * <c>arranged</c> - The videos appear as arranged by the owner of the event.
///  * <c>comments</c> - The videos appear according to their number of comments.
///  * <c>duration</c> - The videos appear in order of duration.
///  * <c>likes</c> - The videos appear according to their number of likes.
///  * <c>newest</c> - The videos appear in chronological order, with the newest first.
///  * <c>oldest</c> - The videos appear in chronological order, with the oldest first.
///  * <c>plays</c> - The videos appear according to their number of plays.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlaylistSort>))]
public sealed record PlaylistSort : StringEnum<PlaylistSort>
{
    private PlaylistSort(string value) : base(value)
    {
    }

    public static readonly PlaylistSort AddedFirst = new("added_first");

    public static readonly PlaylistSort AddedLast = new("added_last");

    public static readonly PlaylistSort Alphabetical = new("alphabetical");

    public static readonly PlaylistSort Arranged = new("arranged");

    public static readonly PlaylistSort Comments = new("comments");

    public static readonly PlaylistSort Duration = new("duration");

    public static readonly PlaylistSort Likes = new("likes");

    public static readonly PlaylistSort Newest = new("newest");

    public static readonly PlaylistSort Oldest = new("oldest");

    public static readonly PlaylistSort Plays = new("plays");

    public static PlaylistSort FromValue(string value) => FromValueCore(value);
}
