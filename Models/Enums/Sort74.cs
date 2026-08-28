using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort74>))]
public sealed record Sort74 : StringEnum<Sort74>
{
    private Sort74(string value) : base(value)
    {
    }

    public static readonly Sort74 Alphabetical = new("alphabetical");

    public static readonly Sort74 Date = new("date");

    public static readonly Sort74 Duration = new("duration");

    public static readonly Sort74 Videos = new("videos");

    public static Sort74 FromValue(string value) => FromValueCore(value);
}
