using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// Where the logo renders relative to the title. Null until the logo is enabled.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Position1>))]
public sealed record Position1 : StringEnum<Position1>
{
    private Position1(string value) : base(value)
    {
    }

    public static readonly Position1 Left = new("left");

    public static readonly Position1 Right = new("right");

    public static Position1 FromValue(string value) => FromValueCore(value);
}
