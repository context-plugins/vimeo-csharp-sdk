using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TimeInterval>))]
public sealed record TimeInterval : StringEnum<TimeInterval>
{
    private TimeInterval(string value) : base(value)
    {
    }

    public static readonly TimeInterval Day = new("day");

    public static readonly TimeInterval Month = new("month");

    public static readonly TimeInterval None = new("none");

    public static readonly TimeInterval Week = new("week");

    public static readonly TimeInterval Year = new("year");

    public static TimeInterval FromValue(string value) => FromValueCore(value);
}
