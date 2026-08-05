using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The status of the event.
/// <para>
/// Option descriptions:
///  * <c>ended</c> - The user ended the event.
///  * <c>started</c> - The user started the event.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status13>))]
public sealed record Status13 : StringEnum<Status13>
{
    private Status13(string value) : base(value)
    {
    }

    public static readonly Status13 Ended = new("ended");

    public static readonly Status13 Started = new("started");

    public static Status13 FromValue(string value) => FromValueCore(value);
}
