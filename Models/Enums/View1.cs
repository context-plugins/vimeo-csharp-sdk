using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The authenticated user's privacy preference for views.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can view the user's videos. This privacy setting appears as <c>Public</c> on the Vimeo front end.
///  * <c>contacts</c> - Only contacts can view the user's videos. _This field is deprecated._
///  * <c>disable</c> - Views are disabled for the user's videos. This privacy setting appears as <c>Embed only</c> on the Vimeo front end.
///  * <c>nobody</c> - No one except the user can view the user's videos. This privacy setting appears as <c>Private</c> on the Vimeo front end.
///  * <c>password</c> - Only those with the password can view the user's videos.
///  * <c>unlisted</c> - Anybody can view the user's videos if they have a link.
///  * <c>users</c> - Only other Vimeo members can view the user's videos. _This field is deprecated._
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<View1>))]
public sealed record View1 : StringEnum<View1>
{
    private View1(string value) : base(value)
    {
    }

    public static readonly View1 Anybody = new("anybody");

    public static readonly View1 Contacts = new("contacts");

    public static readonly View1 Disable = new("disable");

    public static readonly View1 Nobody = new("nobody");

    public static readonly View1 Password = new("password");

    public static readonly View1 Unlisted = new("unlisted");

    public static readonly View1 Users = new("users");

    public static View1 FromValue(string value) => FromValueCore(value);
}
