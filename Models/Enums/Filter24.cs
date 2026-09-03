using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter24>))]
public sealed record Filter24 : StringEnum<Filter24>
{
    private Filter24(string value) : base(value)
    {
    }

    public static readonly Filter24 Country = new("country");

    public static readonly Filter24 MyRegion = new("my_region");

    public static Filter24 FromValue(string value) => FromValueCore(value);
}
