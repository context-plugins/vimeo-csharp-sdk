using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The general privacy setting for generated videos and the embed privacy of the entire collection.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can access the videos. This privacy setting appears as <c>Public</c> on the Vimeo front end.
///  * <c>embed_only</c> - The videos don't appear on Vimeo, but they can be embedded elsewhere.
///  * <c>nobody</c> - Only the event owner can access the videos. This privacy setting appears as <c>Private</c> on the Vimeo front end.
///  * <c>password</c> - Only those with the password can access the videos.
///  * <c>team</c> - Anyone on this team can access the videos. This privacy setting appears as <c>Company only</c> on the Vimeo front end.
///  * <c>unlisted</c> - Only those with the private link can access the videos.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<View7>))]
public sealed record View7 : StringEnum<View7>
{
    private View7(string value) : base(value)
    {
    }

    public static readonly View7 Anybody = new("anybody");

    public static readonly View7 EmbedOnly = new("embed_only");

    public static readonly View7 Nobody = new("nobody");

    public static readonly View7 Password = new("password");

    public static readonly View7 Team = new("team");

    public static readonly View7 Unlisted = new("unlisted");

    public static View7 FromValue(string value) => FromValueCore(value);
}
