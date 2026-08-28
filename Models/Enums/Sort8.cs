using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort8>))]
public sealed record Sort8 : StringEnum<Sort8>
{
    private Sort8(string value) : base(value)
    {
    }

    public static readonly Sort8 Alphabetical = new("alphabetical");

    public static readonly Sort8 Date = new("date");

    public static Sort8 FromValue(string value) => FromValueCore(value);
}
