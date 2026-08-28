using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort44>))]
public sealed record Sort44 : StringEnum<Sort44>
{
    private Sort44(string value) : base(value)
    {
    }

    public static readonly Sort44 Date = new("date");

    public static readonly Sort44 Default = new("default");

    public static readonly Sort44 Manual = new("manual");

    public static readonly Sort44 Name = new("name");

    public static readonly Sort44 PurchaseTime = new("purchase_time");

    public static readonly Sort44 ReleaseDate = new("release_date");

    public static Sort44 FromValue(string value) => FromValueCore(value);
}
