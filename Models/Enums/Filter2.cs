using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter2>))]
public sealed record Filter2 : StringEnum<Filter2>
{
    private Filter2(string value) : base(value)
    {
    }

    public static readonly Filter2 Moderators = new("moderators");

    public static Filter2 FromValue(string value) => FromValueCore(value);
}
