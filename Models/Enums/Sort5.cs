using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort5>))]
public sealed record Sort5 : StringEnum<Sort5>
{
    private Sort5(string value) : base(value)
    {
    }

    public static readonly Sort5 Alphabetical = new("alphabetical");

    public static readonly Sort5 Date = new("date");

    public static readonly Sort5 Members = new("members");

    public static readonly Sort5 Videos = new("videos");

    public static Sort5 FromValue(string value) => FromValueCore(value);
}
