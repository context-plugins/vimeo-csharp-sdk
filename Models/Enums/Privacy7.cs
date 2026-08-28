using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The privacy level of the channel.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can access the channel.
///  * <c>moderators</c> - Only moderators can access the channel.
///  * <c>user</c> - Only moderators and designated users can access the channel.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Privacy7>))]
public sealed record Privacy7 : StringEnum<Privacy7>
{
    private Privacy7(string value) : base(value)
    {
    }

    public static readonly Privacy7 Anybody = new("anybody");

    public static readonly Privacy7 Moderators = new("moderators");

    public static readonly Privacy7 User = new("user");

    public static Privacy7 FromValue(string value) => FromValueCore(value);
}
