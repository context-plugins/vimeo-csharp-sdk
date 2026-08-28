using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The status of the event.
/// <para>
/// Option descriptions:
///  * <c>ended</c> - The event has ended.
///  * <c>started</c> - The event has started.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status15>))]
public sealed record Status15 : StringEnum<Status15>
{
    private Status15(string value) : base(value)
    {
    }

    public static readonly Status15 Ended = new("ended");

    public static readonly Status15 Started = new("started");

    public static Status15 FromValue(string value) => FromValueCore(value);
}
