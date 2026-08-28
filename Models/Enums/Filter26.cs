using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter26>))]
public sealed record Filter26 : StringEnum<Filter26>
{
    private Filter26(string value) : base(value)
    {
    }

    public static readonly Filter26 Batch = new("batch");

    public static readonly Filter26 Default = new("default");

    public static readonly Filter26 Single = new("single");

    public static readonly Filter26 Vip = new("vip");

    public static Filter26 FromValue(string value) => FromValueCore(value);
}
