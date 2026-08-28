using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort45>))]
public sealed record Sort45 : StringEnum<Sort45>
{
    private Sort45(string value) : base(value)
    {
    }

    public static readonly Sort45 Date = new("date");

    public static readonly Sort45 Default = new("default");

    public static readonly Sort45 Episode = new("episode");

    public static readonly Sort45 Manual = new("manual");

    public static readonly Sort45 Name = new("name");

    public static readonly Sort45 PurchaseTime = new("purchase_time");

    public static readonly Sort45 ReleaseDate = new("release_date");

    public static Sort45 FromValue(string value) => FromValueCore(value);
}
