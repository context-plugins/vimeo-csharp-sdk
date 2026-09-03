using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The authenticated user's content filters.
/// <para>
/// Option descriptions:
///  * <c>drugs</c> - The content contains drug or alcohol use.
///  * <c>language</c> - The content contains profanity or sexually suggestive language.
///  * <c>nudity</c> - The content contains nudity.
///  * <c>safe</c> - The content is suitable for all audiences.
///  * <c>unrated</c> - The content hasn't been rated.
///  * <c>violence</c> - The content contains violence or is graphic.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContentFilter>))]
public sealed record ContentFilter : StringEnum<ContentFilter>
{
    private ContentFilter(string value) : base(value)
    {
    }

    public static readonly ContentFilter Drugs = new("drugs");

    public static readonly ContentFilter Language = new("language");

    public static readonly ContentFilter Nudity = new("nudity");

    public static readonly ContentFilter Safe = new("safe");

    public static readonly ContentFilter Unrated = new("unrated");

    public static readonly ContentFilter Violence = new("violence");

    public static ContentFilter FromValue(string value) => FromValueCore(value);
}
