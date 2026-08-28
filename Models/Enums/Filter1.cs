using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter1>))]
public sealed record Filter1 : StringEnum<Filter1>
{
    private Filter1(string value) : base(value)
    {
    }

    public static readonly Filter1 Featured = new("featured");

    public static Filter1 FromValue(string value) => FromValueCore(value);
}
