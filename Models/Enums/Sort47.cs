using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort47>))]
public sealed record Sort47 : StringEnum<Sort47>
{
    private Sort47(string value) : base(value)
    {
    }

    public static readonly Sort47 CreatedTime = new("created_time");

    public static readonly Sort47 Duration = new("duration");

    public static readonly Sort47 Name = new("name");

    public static Sort47 FromValue(string value) => FromValueCore(value);
}
