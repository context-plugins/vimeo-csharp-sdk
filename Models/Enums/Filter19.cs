using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter19>))]
public sealed record Filter19 : StringEnum<Filter19>
{
    private Filter19(string value) : base(value)
    {
    }

    public static readonly Filter19 All = new("all");

    public static readonly Filter19 ExpiringSoon = new("expiring_soon");

    public static readonly Filter19 Film = new("film");

    public static readonly Filter19 Important = new("important");

    public static readonly Filter19 Purchased = new("purchased");

    public static readonly Filter19 Rented = new("rented");

    public static readonly Filter19 Series = new("series");

    public static readonly Filter19 Subscription = new("subscription");

    public static readonly Filter19 Unwatched = new("unwatched");

    public static readonly Filter19 Watched = new("watched");

    public static Filter19 FromValue(string value) => FromValueCore(value);
}
