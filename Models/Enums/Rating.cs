using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// An array of the authorized user's default content ratings.
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
[JsonConverter(typeof(StringEnumConverter<Rating>))]
public sealed record Rating : StringEnum<Rating>
{
    private Rating(string value) : base(value)
    {
    }

    public static readonly Rating Drugs = new("drugs");

    public static readonly Rating Language = new("language");

    public static readonly Rating Nudity = new("nudity");

    public static readonly Rating Safe = new("safe");

    public static readonly Rating Unrated = new("unrated");

    public static readonly Rating Violence = new("violence");

    public static Rating FromValue(string value) => FromValueCore(value);
}
