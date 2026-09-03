using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The privacy setting for accessing the folder.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone with the link can access the contents of the folder. This privacy setting appears as <c>Public</c> on the Vimeo front end.
///  * <c>nobody</c> - Only the owner and those team members that the owner has explicitly invited can access the contents of the folder. This privacy setting appears as <c>Private</c> on the Vimeo front end.
///  * <c>team</c> - Only those team members with the link can access the contents of the folder.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<View3>))]
public sealed record View3 : StringEnum<View3>
{
    private View3(string value) : base(value)
    {
    }

    public static readonly View3 Anybody = new("anybody");

    public static readonly View3 Nobody = new("nobody");

    public static readonly View3 Team = new("team");

    public static View3 FromValue(string value) => FromValueCore(value);
}
