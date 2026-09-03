using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter29>))]
public sealed record Filter29 : StringEnum<Filter29>
{
    private Filter29(string value) : base(value)
    {
    }

    public static readonly Filter29 All = new("all");

    public static readonly Filter29 Buy = new("buy");

    public static readonly Filter29 ExpiringSoon = new("expiring_soon");

    public static readonly Filter29 Extra = new("extra");

    public static readonly Filter29 Main = new("main");

    public static readonly Filter29 MainViewable = new("main.viewable");

    public static readonly Filter29 Rent = new("rent");

    public static readonly Filter29 Trailer = new("trailer");

    public static readonly Filter29 Unwatched = new("unwatched");

    public static readonly Filter29 Viewable = new("viewable");

    public static readonly Filter29 Watched = new("watched");

    public static Filter29 FromValue(string value) => FromValueCore(value);
}
