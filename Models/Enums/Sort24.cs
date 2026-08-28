using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort24>))]
public sealed record Sort24 : StringEnum<Sort24>
{
    private Sort24(string value) : base(value)
    {
    }

    public static readonly Sort24 Alphabetical = new("alphabetical");

    public static readonly Sort24 Date = new("date");

    public static readonly Sort24 Name = new("name");

    public static Sort24 FromValue(string value) => FromValueCore(value);
}
