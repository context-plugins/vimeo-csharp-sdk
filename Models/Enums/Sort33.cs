using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort33>))]
public sealed record Sort33 : StringEnum<Sort33>
{
    private Sort33(string value) : base(value)
    {
    }

    public static readonly Sort33 Added = new("added");

    public static readonly Sort33 Alphabetical = new("alphabetical");

    public static readonly Sort33 Date = new("date");

    public static readonly Sort33 Name = new("name");

    public static readonly Sort33 PurchaseTime = new("purchase_time");

    public static readonly Sort33 Rating = new("rating");

    public static readonly Sort33 ReleaseDate = new("release_date");

    public static Sort33 FromValue(string value) => FromValueCore(value);
}
