using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The privacy level of the channel.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can access the channel.
///  * <c>moderators</c> - Only moderators can access the channel.
///  * <c>users</c> - Only moderators and designated users can access the channel.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Privacy8>))]
public sealed record Privacy8 : StringEnum<Privacy8>
{
    private Privacy8(string value) : base(value)
    {
    }

    public static readonly Privacy8 Anybody = new("anybody");

    public static readonly Privacy8 Moderators = new("moderators");

    public static readonly Privacy8 Users = new("users");

    public static Privacy8 FromValue(string value) => FromValueCore(value);
}
