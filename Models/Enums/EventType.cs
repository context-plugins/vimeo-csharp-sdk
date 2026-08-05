using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of event.
/// <para>
/// Option descriptions:
///  * <c>default</c> - The event type is a regular recurring event.
///  * <c>venue</c> - The event type is a venue.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EventType>))]
public sealed record EventType : StringEnum<EventType>
{
    private EventType(string value) : base(value)
    {
    }

    public static readonly EventType Default = new("default");

    public static readonly EventType Venue = new("venue");

    public static EventType FromValue(string value) => FromValueCore(value);
}
