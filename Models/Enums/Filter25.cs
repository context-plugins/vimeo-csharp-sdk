using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter25>))]
public sealed record Filter25 : StringEnum<Filter25>
{
    private Filter25(string value) : base(value)
    {
    }

    public static readonly Filter25 Extra = new("extra");

    public static readonly Filter25 Main = new("main");

    public static readonly Filter25 Trailer = new("trailer");

    public static Filter25 FromValue(string value) => FromValueCore(value);
}
