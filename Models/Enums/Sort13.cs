using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort13>))]
public sealed record Sort13 : StringEnum<Sort13>
{
    private Sort13(string value) : base(value)
    {
    }

    public static readonly Sort13 Alphabetical = new("alphabetical");

    public static readonly Sort13 Date = new("date");

    public static readonly Sort13 Followers = new("followers");

    public static readonly Sort13 Relevant = new("relevant");

    public static readonly Sort13 Videos = new("videos");

    public static Sort13 FromValue(string value) => FromValueCore(value);
}
