using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort18>))]
public sealed record Sort18 : StringEnum<Sort18>
{
    private Sort18(string value) : base(value)
    {
    }

    public static readonly Sort18 Alphabetical = new("alphabetical");

    public static readonly Sort18 Date = new("date");

    public static readonly Sort18 Duration = new("duration");

    public static readonly Sort18 LastModified = new("last_modified");

    public static readonly Sort18 Videos = new("videos");

    public static Sort18 FromValue(string value) => FromValueCore(value);
}
