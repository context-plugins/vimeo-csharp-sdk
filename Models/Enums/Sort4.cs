using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort4>))]
public sealed record Sort4 : StringEnum<Sort4>
{
    private Sort4(string value) : base(value)
    {
    }

    public static readonly Sort4 Alphabetical = new("alphabetical");

    public static readonly Sort4 Date = new("date");

    public static readonly Sort4 Followers = new("followers");

    public static readonly Sort4 Videos = new("videos");

    public static Sort4 FromValue(string value) => FromValueCore(value);
}
