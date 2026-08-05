using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter30>))]
public sealed record Filter30 : StringEnum<Filter30>
{
    private Filter30(string value) : base(value)
    {
    }

    public static readonly Filter30 Video = new("video");

    public static Filter30 FromValue(string value) => FromValueCore(value);
}
