using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The team member's permission level.
/// <para>
/// Option descriptions:
///  * <c>Admin</c> - The team member has admin permissions. They can upload and edit videos for the entire team and perform team administration tasks.
///  * <c>Contributor</c> - The team member has contributor permissions. They can upload and edit videos for the entire team but can't perform team administration tasks.
///  * <c>Contributor Plus</c> - The team member has contributor plus permissions. They can upload and edit videos for the entire team, and have additional sets of permissions, but can't perform team administration tasks.
///  * <c>Owner</c> - The team member has owner permissions.
///  * <c>Uploader</c> - The team member has uploader permissions. They can upload videos for the entire team but can't edit videos.
///  * <c>Viewer</c> - The team member has viewer permissions. They can access team videos and specific team folders but can't upload or edit videos.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PermissionLevel1>))]
public sealed record PermissionLevel1 : StringEnum<PermissionLevel1>
{
    private PermissionLevel1(string value) : base(value)
    {
    }

    public static readonly PermissionLevel1 Admin = new("Admin");

    public static readonly PermissionLevel1 Contributor = new("Contributor");

    public static readonly PermissionLevel1 ContributorPlus = new("Contributor Plus");

    public static readonly PermissionLevel1 Owner = new("Owner");

    public static readonly PermissionLevel1 Uploader = new("Uploader");

    public static readonly PermissionLevel1 Viewer = new("Viewer");

    public static PermissionLevel1 FromValue(string value) => FromValueCore(value);
}
