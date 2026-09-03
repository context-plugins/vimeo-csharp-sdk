using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The content rating of the video, given either as a comma-separated list or as a JSON array, depending on the request format.
/// <para>
/// Option descriptions:
///  * <c>drugs</c> - The video contains drug or alcohol use.
///  * <c>language</c> - The video contains profanity or sexually suggestive content.
///  * <c>nudity</c> - The video contains nudity.
///  * <c>safe</c> - The video is suitable for all audiences.
///  * <c>unrated</c> - The video hasn't been rated.
///  * <c>violence</c> - The video contains violent or graphic content.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContentRating1>))]
public sealed record ContentRating1 : StringEnum<ContentRating1>
{
    private ContentRating1(string value) : base(value)
    {
    }

    public static readonly ContentRating1 Drugs = new("drugs");

    public static readonly ContentRating1 Language = new("language");

    public static readonly ContentRating1 Nudity = new("nudity");

    public static readonly ContentRating1 Safe = new("safe");

    public static readonly ContentRating1 Unrated = new("unrated");

    public static readonly ContentRating1 Violence = new("violence");

    public static ContentRating1 FromValue(string value) => FromValueCore(value);
}
