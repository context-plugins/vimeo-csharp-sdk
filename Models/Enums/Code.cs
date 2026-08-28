using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The reason for the content rating.
/// <para>
/// Option descriptions:
///  * <c>advertisement</c> - The content contains an advertisement.
///  * <c>drugs</c> - The content contains drug or alcohol use.
///  * <c>language</c> - The content contains profanity or sexually suggestive language.
///  * <c>nudity</c> - The content contains nudity.
///  * <c>safe</c> - The content is suitable for all audiences.
///  * <c>unrated</c> - The content hasn't been rated.
///  * <c>violence</c> - The content contains violence or is graphic.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Code>))]
public sealed record Code : StringEnum<Code>
{
    private Code(string value) : base(value)
    {
    }

    public static readonly Code Advertisement = new("advertisement");

    public static readonly Code Drugs = new("drugs");

    public static readonly Code Language = new("language");

    public static readonly Code Nudity = new("nudity");

    public static readonly Code Safe = new("safe");

    public static readonly Code Unrated = new("unrated");

    public static readonly Code Violence = new("violence");

    public static Code FromValue(string value) => FromValueCore(value);
}
