using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The default sort order of the videos as they appear in the showcase.
/// <para>
/// Option descriptions:
///  * <c>added_first</c> - The videos appear according to when they were added to the showcase, with the most recently added first.
///  * <c>added_last</c> - The videos appear according to when they were added to the showcase, with the most recently added last.
///  * <c>alphabetical</c> - The videos appear alphabetically by their title.
///  * <c>alphabetical_desc</c> - The videos appear alphabetically by their title in reverse order.
///  * <c>arranged</c> - The videos appear as arranged by the owner of the showcase.
///  * <c>comments</c> - The videos appear according to their number of comments.
///  * <c>likes</c> - The videos appear according to their number of likes.
///  * <c>modified_time_asc</c> - The videos appear in ascending order based on their last modified time.
///  * <c>modified_time_desc</c> - The videos appear in descending order based on their last modified time.
///  * <c>newest</c> - The videos appear in chronological order with the newest first.
///  * <c>oldest</c> - The videos appear in chronological order with the oldest first.
///  * <c>plays</c> - The videos appear according to their number of plays.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Sort19>))]
public sealed record Sort19 : StringEnum<Sort19>
{
    private Sort19(string value) : base(value)
    {
    }

    public static readonly Sort19 AddedFirst = new("added_first");

    public static readonly Sort19 AddedLast = new("added_last");

    public static readonly Sort19 Alphabetical = new("alphabetical");

    public static readonly Sort19 AlphabeticalDesc = new("alphabetical_desc");

    public static readonly Sort19 Arranged = new("arranged");

    public static readonly Sort19 Comments = new("comments");

    public static readonly Sort19 Likes = new("likes");

    public static readonly Sort19 ModifiedTimeAsc = new("modified_time_asc");

    public static readonly Sort19 ModifiedTimeDesc = new("modified_time_desc");

    public static readonly Sort19 Newest = new("newest");

    public static readonly Sort19 Oldest = new("oldest");

    public static readonly Sort19 Plays = new("plays");

    public static Sort19 FromValue(string value) => FromValueCore(value);
}
