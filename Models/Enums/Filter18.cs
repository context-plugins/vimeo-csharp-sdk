using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter18>))]
public sealed record Filter18 : StringEnum<Filter18>
{
    private Filter18(string value) : base(value)
    {
    }

    public static readonly Filter18 Film = new("film");

    public static readonly Filter18 Series = new("series");

    public static Filter18 FromValue(string value) => FromValueCore(value);
}
