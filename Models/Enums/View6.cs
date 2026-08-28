using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The access level of the showcase.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can access the showcase. This privacy setting appears as <c>Public</c> on the Vimeo front end.
///  * <c>embed_only</c> - The showcase doesn't appear on Vimeo, but the owner can embed it on other sites.
///  * <c>nobody</c> - No one can access the showacse, including the owner. This privacy setting appears as <c>Private</c> on the Vimeo front end.
///  * <c>password</c> - Only those with the password can access the showcase.
///  * <c>team</c> - Only the owner and members of the owner's team can access the showcase.
///  * <c>unlisted</c> - The showcase can't be accessed if the URL omits its unlisted hash.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<View6>))]
public sealed record View6 : StringEnum<View6>
{
    private View6(string value) : base(value)
    {
    }

    public static readonly View6 Anybody = new("anybody");

    public static readonly View6 EmbedOnly = new("embed_only");

    public static readonly View6 Nobody = new("nobody");

    public static readonly View6 Password = new("password");

    public static readonly View6 Team = new("team");

    public static readonly View6 Unlisted = new("unlisted");

    public static View6 FromValue(string value) => FromValueCore(value);
}
