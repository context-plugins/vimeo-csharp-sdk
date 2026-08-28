using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The selected video title font weight.
/// <para>
/// Option descriptions:
///  * <c>300</c> - Light
///  * <c>400</c> - Regular
///  * <c>500</c> - Medium
///  * <c>700</c> - Bold
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<TitleFontWeight>))]
public sealed record TitleFontWeight : IntEnum<TitleFontWeight>
{
    private TitleFontWeight(int value) : base(value)
    {
    }

    public static readonly TitleFontWeight Value300 = new(300);

    public static readonly TitleFontWeight Value400 = new(400);

    public static readonly TitleFontWeight Value500 = new(500);

    public static readonly TitleFontWeight Value700 = new(700);

    public static TitleFontWeight FromValue(int value) => FromValueCore(value);
}
