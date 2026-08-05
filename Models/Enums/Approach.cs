using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The approach for uploading the video.
/// <para>
/// Option descriptions:
///  * <c>post</c> - The video upload uses the POST approach.
///  * <c>pull</c> - The video upload uses the pull approach.
///  * <c>tus</c> - The video upload uses the tus approach.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Approach>))]
public sealed record Approach : StringEnum<Approach>
{
    private Approach(string value) : base(value)
    {
    }

    public static readonly Approach Post = new("post");

    public static readonly Approach Pull = new("pull");

    public static readonly Approach Tus = new("tus");

    public static Approach FromValue(string value) => FromValueCore(value);
}
