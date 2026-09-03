using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort43>))]
public sealed record Sort43 : StringEnum<Sort43>
{
    private Sort43(string value) : base(value)
    {
    }

    public static readonly Sort43 Date = new("date");

    public static readonly Sort43 Manual = new("manual");

    public static Sort43 FromValue(string value) => FromValueCore(value);
}
