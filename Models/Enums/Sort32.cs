using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort32>))]
public sealed record Sort32 : StringEnum<Sort32>
{
    private Sort32(string value) : base(value)
    {
    }

    public static readonly Sort32 Added = new("added");

    public static readonly Sort32 Alphabetical = new("alphabetical");

    public static readonly Sort32 Date = new("date");

    public static readonly Sort32 ModifiedTime = new("modified_time");

    public static readonly Sort32 Name = new("name");

    public static readonly Sort32 PublishTime = new("publish.time");

    public static readonly Sort32 Rating = new("rating");

    public static Sort32 FromValue(string value) => FromValueCore(value);
}
