using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The privacy setting of the channel.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can access the channel. This privacy setting appears as <c>Public</c> on the Vimeo front end.
///  * <c>moderators</c> - Only moderators can access the channel.
///  * <c>users</c> - Only registered users can access the channel. _This field is deprecated._
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<View>))]
public sealed record View : StringEnum<View>
{
    private View(string value) : base(value)
    {
    }

    public static readonly View Anybody = new("anybody");

    public static readonly View Moderators = new("moderators");

    public static readonly View Users = new("users");

    public static View FromValue(string value) => FromValueCore(value);
}
