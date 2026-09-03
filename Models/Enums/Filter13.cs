using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter13>))]
public sealed record Filter13 : StringEnum<Filter13>
{
    private Filter13(string value) : base(value)
    {
    }

    public static readonly Filter13 Online = new("online");

    public static Filter13 FromValue(string value) => FromValueCore(value);
}
