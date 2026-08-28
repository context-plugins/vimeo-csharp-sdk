using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of picture.
/// <para>
/// Option descriptions:
///  * <c>caution</c> - The picture isn't appropriate for all ages.
///  * <c>custom</c> - The picture is a custom video image.
///  * <c>default</c> - The picture is the default video image.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Caution = new("caution");

    public static readonly TypeEnum Custom = new("custom");

    public static readonly TypeEnum Default = new("default");

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
