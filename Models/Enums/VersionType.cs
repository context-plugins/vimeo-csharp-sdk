using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of the version.
/// <para>
/// Option descriptions:
///  * <c>regular</c> - The version was generated through a file upload.
///  * <c>screen-recording</c> - The version was generated through Vimeo Record.
///  * <c>vimeo-create</c> - The version was generated through Vimeo Create.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VersionType>))]
public sealed record VersionType : StringEnum<VersionType>
{
    private VersionType(string value) : base(value)
    {
    }

    public static readonly VersionType Regular = new("regular");

    public static readonly VersionType ScreenRecording = new("screen-recording");

    public static readonly VersionType VimeoCreate = new("vimeo-create");

    public static VersionType FromValue(string value) => FromValueCore(value);
}
