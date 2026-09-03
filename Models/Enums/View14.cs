using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The video's privacy setting. When this value is <c>users</c>, <c>application/json</c> is the only valid content type. Also, some privacy settings are unavailable to Vimeo Free members; for more information, see our <see href="https://vimeo.zendesk.com/hc/en-us/articles/224817847">Help Center</see>.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can access the video. This privacy setting appears as <c>Public</c> on the Vimeo front end.
///  * <c>contacts</c> - Only those who follow the owner on Vimeo can access the video. _This field is deprecated._
///  * <c>disable</c> - The video is embeddable, but it's hidden on Vimeo and can't be played. This privacy setting appears as <c>Embed only</c> on the Vimeo front end.
///  * <c>nobody</c> - No one except the owner can access the video. This privacy setting appears as <c>Private</c> on the Vimeo front end.
///  * <c>password</c> - Only those with the password can access the video.
///  * <c>team</c> - Anyone on the team can access the video. This privacy setting appears as <c>Company only</c> on the Vimeo front end.
///  * <c>unlisted</c> - Only those with the private link can access the video.
///  * <c>users</c> - Only Vimeo members can access the video. _This field is deprecated._
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<View14>))]
public sealed record View14 : StringEnum<View14>
{
    private View14(string value) : base(value)
    {
    }

    public static readonly View14 Anybody = new("anybody");

    public static readonly View14 Contacts = new("contacts");

    public static readonly View14 Disable = new("disable");

    public static readonly View14 Nobody = new("nobody");

    public static readonly View14 Password = new("password");

    public static readonly View14 Team = new("team");

    public static readonly View14 Unlisted = new("unlisted");

    public static readonly View14 Users = new("users");

    public static View14 FromValue(string value) => FromValueCore(value);
}
