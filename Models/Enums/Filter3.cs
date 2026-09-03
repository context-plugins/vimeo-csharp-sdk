using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter3>))]
public sealed record Filter3 : StringEnum<Filter3>
{
    private Filter3(string value) : base(value)
    {
    }

    public static readonly Filter3 Embeddable = new("embeddable");

    public static Filter3 FromValue(string value) => FromValueCore(value);
}
