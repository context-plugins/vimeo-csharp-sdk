using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The event's granular content ratings.
/// <para>
/// Option descriptions:
///  * <c>advertisement</c> - The event contains advertisements.
///  * <c>drugs</c> - The event contains drug or alcohol use.
///  * <c>language</c> - The event contains profanity or sexually suggestive content.
///  * <c>nudity</c> - The event contains nudity.
///  * <c>safe</c> - The event is safe for all audiences.
///  * <c>unrated</c> - The event hasn't been rated.
///  * <c>violence</c> - The event contains violence.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContentRating2>))]
public sealed record ContentRating2 : StringEnum<ContentRating2>
{
    private ContentRating2(string value) : base(value)
    {
    }

    public static readonly ContentRating2 Advertisement = new("advertisement");

    public static readonly ContentRating2 Drugs = new("drugs");

    public static readonly ContentRating2 Language = new("language");

    public static readonly ContentRating2 Nudity = new("nudity");

    public static readonly ContentRating2 Safe = new("safe");

    public static readonly ContentRating2 Unrated = new("unrated");

    public static readonly ContentRating2 Violence = new("violence");

    public static ContentRating2 FromValue(string value) => FromValueCore(value);
}
