using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// An array of the user's default content ratings.
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
[JsonConverter(typeof(StringEnumConverter<Rating1>))]
public sealed record Rating1 : StringEnum<Rating1>
{
    private Rating1(string value) : base(value)
    {
    }

    public static readonly Rating1 Drugs = new("drugs");

    public static readonly Rating1 Language = new("language");

    public static readonly Rating1 Nudity = new("nudity");

    public static readonly Rating1 Safe = new("safe");

    public static readonly Rating1 Unrated = new("unrated");

    public static readonly Rating1 Violence = new("violence");

    public static Rating1 FromValue(string value) => FromValueCore(value);
}
