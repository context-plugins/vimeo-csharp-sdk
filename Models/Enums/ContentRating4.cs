using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The video's granular content rating.
/// <para>
/// Option descriptions:
///  * <c>advertisement</c> - The video contains advertisements.
///  * <c>drugs</c> - The video contains drug or alcohol use.
///  * <c>language</c> - The video contains profanity or sexually suggestive content.
///  * <c>nudity</c> - The video contains nudity.
///  * <c>safe</c> - The video is safe for all audiences.
///  * <c>unrated</c> - The video hasn't been rated.
///  * <c>violence</c> - The video contains violence.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContentRating4>))]
public sealed record ContentRating4 : StringEnum<ContentRating4>
{
    private ContentRating4(string value) : base(value)
    {
    }

    public static readonly ContentRating4 Advertisement = new("advertisement");

    public static readonly ContentRating4 Drugs = new("drugs");

    public static readonly ContentRating4 Language = new("language");

    public static readonly ContentRating4 Nudity = new("nudity");

    public static readonly ContentRating4 Safe = new("safe");

    public static readonly ContentRating4 Unrated = new("unrated");

    public static readonly ContentRating4 Violence = new("violence");

    public static ContentRating4 FromValue(string value) => FromValueCore(value);
}
