using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// Who can access the user's videos by default.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can access the videos. This privacy setting appears as <c>Public</c> on the Vimeo front end.
///  * <c>contacts</c> - Only the user's contacts can access the videos. _This field is deprecated._
///  * <c>disable</c> - The videos are disabled. This privacy setting appears as <c>Embed only</c> on the Vimeo front end.
///  * <c>nobody</c> - No one can access the videos. This privacy setting appears as <c>Private</c> on the Vimeo front end.
///  * <c>password</c> - Only those with the password can access the videos.
///  * <c>unlisted</c> - The videos are unlisted.
///  * <c>users</c> - Only other Vimeo members can access the videos. _This field is deprecated._
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<View11>))]
public sealed record View11 : StringEnum<View11>
{
    private View11(string value) : base(value)
    {
    }

    public static readonly View11 Anybody = new("anybody");

    public static readonly View11 Contacts = new("contacts");

    public static readonly View11 Disable = new("disable");

    public static readonly View11 Nobody = new("nobody");

    public static readonly View11 Password = new("password");

    public static readonly View11 Unlisted = new("unlisted");

    public static readonly View11 Users = new("users");

    public static View11 FromValue(string value) => FromValueCore(value);
}
