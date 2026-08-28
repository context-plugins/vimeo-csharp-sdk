using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of video.
/// <para>
/// Option descriptions:
///  * <c>extra</c> - The video is an extra feature.
///  * <c>main</c> - The video is a main feature.
///  * <c>trailer</c> - The video is a trailer.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type23>))]
public sealed record Type23 : StringEnum<Type23>
{
    private Type23(string value) : base(value)
    {
    }

    public static readonly Type23 Extra = new("extra");

    public static readonly Type23 Main = new("main");

    public static readonly Type23 Trailer = new("trailer");

    public static Type23 FromValue(string value) => FromValueCore(value);
}
