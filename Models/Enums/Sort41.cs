using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort41>))]
public sealed record Sort41 : StringEnum<Sort41>
{
    private Sort41(string value) : base(value)
    {
    }

    public static readonly Sort41 Alphabetical = new("alphabetical");

    public static readonly Sort41 Date = new("date");

    public static readonly Sort41 Name = new("name");

    public static readonly Sort41 PublishTime = new("publish.time");

    public static readonly Sort41 Videos = new("videos");

    public static Sort41 FromValue(string value) => FromValueCore(value);
}
