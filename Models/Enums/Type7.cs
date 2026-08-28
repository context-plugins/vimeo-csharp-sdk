using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of the video.
/// <para>
/// Option descriptions:
///  * <c>live</c> - The video is or was an event.
///  * <c>stock</c> - The video is a Vimeo Stock video.
///  * <c>video</c> - The video is a standard Vimeo video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type7>))]
public sealed record Type7 : StringEnum<Type7>
{
    private Type7(string value) : base(value)
    {
    }

    public static readonly Type7 Live = new("live");

    public static readonly Type7 Stock = new("stock");

    public static readonly Type7 Video = new("video");

    public static Type7 FromValue(string value) => FromValueCore(value);
}
