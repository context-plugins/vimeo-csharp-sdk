using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The untranslated role of the user who made the request.
/// <para>
/// Option descriptions:
///  * <c>Admin</c> - The team member has admin permissions. They can upload and edit videos for the entire team and perform team administration tasks.
///  * <c>Contributor</c> - The team member has contributor permissions. They can upload and edit videos for the entire team but can’t perform team administration tasks.
///  * <c>Contributor Plus</c> - The team member has contributor-plus permissions. They can upload and edit videos for the entire team and have additional sets of permissions but can't perform team administration tasks.
///  * <c>Owner</c> - The team member has owner permissions.
///  * <c>Uploader</c> - The team member has uploader permissions. They can upload videos for the entire team but can’t edit videos.
///  * <c>Viewer</c> - The team member has viewer permissions. They can access team videos and specific team folders but can’t upload or edit videos.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Role>))]
public sealed record Role : StringEnum<Role>
{
    private Role(string value) : base(value)
    {
    }

    public static readonly Role Admin = new("Admin");

    public static readonly Role Contributor = new("Contributor");

    public static readonly Role ContributorPlus = new("Contributor Plus");

    public static readonly Role Owner = new("Owner");

    public static readonly Role Uploader = new("Uploader");

    public static readonly Role Viewer = new("Viewer");

    public static Role FromValue(string value) => FromValueCore(value);
}
