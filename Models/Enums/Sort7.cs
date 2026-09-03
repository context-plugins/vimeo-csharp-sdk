using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort7>))]
public sealed record Sort7 : StringEnum<Sort7>
{
    private Sort7(string value) : base(value)
    {
    }

    public static readonly Sort7 Alphabetical = new("alphabetical");

    public static readonly Sort7 Date = new("date");

    public static readonly Sort7 Default = new("default");

    public static readonly Sort7 Followers = new("followers");

    public static readonly Sort7 Relevant = new("relevant");

    public static readonly Sort7 Videos = new("videos");

    public static Sort7 FromValue(string value) => FromValueCore(value);
}
