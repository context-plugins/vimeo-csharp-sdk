using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The privacy setting of the destination.
/// <para>
/// Option descriptions:
///  * <c>CONNECTIONS</c> - The privacy setting is <c>CONNECTIONS</c> for LinkedIn.
///  * <c>PUBLIC</c> - The privacy setting is <c>PUBLIC</c> for LinkedIn.
///  * <c>all_friends</c> - The privacy setting is <c>all_friends</c> for Facebook.
///  * <c>everyone</c> - The privacy setting is <c>everyone</c> for Facebook.
///  * <c>private</c> - The privacy setting is <c>private</c> for YouTube.
///  * <c>public</c> - The privacy setting is <c>public</c> for YouTube.
///  * <c>self</c> - The privacy setting is <c>self</c> for Facebook.
///  * <c>unlisted</c> - The privacy setting is <c>unlisted</c> for YouTube.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Privacy6>))]
public sealed record Privacy6 : StringEnum<Privacy6>
{
    private Privacy6(string value) : base(value)
    {
    }

    public static readonly Privacy6 Connections = new("CONNECTIONS");

    public static readonly Privacy6 Public = new("PUBLIC");

    public static readonly Privacy6 AllFriends = new("all_friends");

    public static readonly Privacy6 Everyone = new("everyone");

    public static readonly Privacy6 Private = new("private");

    public static readonly Privacy6 Public2 = new("public");

    public static readonly Privacy6 Self = new("self");

    public static readonly Privacy6 Unlisted = new("unlisted");

    public static Privacy6 FromValue(string value) => FromValueCore(value);
}
