using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The video's high-level content rating class.
/// <para>
/// Option descriptions:
///  * <c>explicit</c> - The video contains one or more explicit content rating types.
///  * <c>safe</c> - The video contains no explicit content rating types.
///  * <c>unrated</c> - The video doesn't belong to a content rating class.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ContentRatingClass>))]
public sealed record ContentRatingClass : StringEnum<ContentRatingClass>
{
    private ContentRatingClass(string value) : base(value)
    {
    }

    public static readonly ContentRatingClass Explicit = new("explicit");

    public static readonly ContentRatingClass Safe = new("safe");

    public static readonly ContentRatingClass Unrated = new("unrated");

    public static ContentRatingClass FromValue(string value) => FromValueCore(value);
}
