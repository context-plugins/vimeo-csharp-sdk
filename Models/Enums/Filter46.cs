using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter46>))]
public sealed record Filter46 : StringEnum<Filter46>
{
    private Filter46(string value) : base(value)
    {
    }

    public static readonly Filter46 Related = new("related");

    public static Filter46 FromValue(string value) => FromValueCore(value);
}
