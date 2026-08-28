using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter27>))]
public sealed record Filter27 : StringEnum<Filter27>
{
    private Filter27(string value) : base(value)
    {
    }

    public static readonly Filter27 Viewable = new("viewable");

    public static Filter27 FromValue(string value) => FromValueCore(value);
}
