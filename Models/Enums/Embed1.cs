using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The video's embed permission setting.
/// <para>
/// Option descriptions:
///  * <c>private</c> - The video is private.
///  * <c>public</c> - Anyone can embed the video.
///  * <c>whitelist</c> - The video can be embedded on specific domains.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Embed1>))]
public sealed record Embed1 : StringEnum<Embed1>
{
    private Embed1(string value) : base(value)
    {
    }

    public static readonly Embed1 Private = new("private");

    public static readonly Embed1 Public = new("public");

    public static readonly Embed1 Whitelist = new("whitelist");

    public static Embed1 FromValue(string value) => FromValueCore(value);
}
