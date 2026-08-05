using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The project item type.
/// <para>
/// Option descriptions:
///  * <c>folder</c> - The project item is a folder.
///  * <c>live_event</c> - The project item is an event.
///  * <c>showcase</c> - The project item is a showcase.
///  * <c>video</c> - The project item is a video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type21>))]
public sealed record Type21 : StringEnum<Type21>
{
    private Type21(string value) : base(value)
    {
    }

    public static readonly Type21 Folder = new("folder");

    public static readonly Type21 LiveEvent = new("live_event");

    public static readonly Type21 Showcase = new("showcase");

    public static readonly Type21 Video = new("video");

    public static Type21 FromValue(string value) => FromValueCore(value);
}
