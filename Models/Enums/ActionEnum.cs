using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The relevant contextual action.
/// <para>
/// Option descriptions:
///  * <c>Added to</c> - An Added To action.
///  * <c>Appearance by</c> - An Appearance By action.
///  * <c>Liked by</c> - A Liked By action.
///  * <c>Uploaded by</c> - An Uploaded By action.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ActionEnum>))]
public sealed record ActionEnum : StringEnum<ActionEnum>
{
    private ActionEnum(string value) : base(value)
    {
    }

    public static readonly ActionEnum AddedTo = new("Added to");

    public static readonly ActionEnum AppearanceBy = new("Appearance by");

    public static readonly ActionEnum LikedBy = new("Liked by");

    public static readonly ActionEnum UploadedBy = new("Uploaded by");

    public static ActionEnum FromValue(string value) => FromValueCore(value);
}
