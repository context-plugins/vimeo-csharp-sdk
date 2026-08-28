using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of latency.
/// <para>
/// Option descriptions:
///  * <c>fail-safe</c> - The latency is in the failsafe range, with a delay of 60-75 seconds.
///  * <c>low</c> - The latency is low, with a delay of 5-7 seconds.
///  * <c>standard</c> - The latency is standard, with a delay of 15-20 seconds.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Latency>))]
public sealed record Latency : StringEnum<Latency>
{
    private Latency(string value) : base(value)
    {
    }

    public static readonly Latency FailSafe = new("fail-safe");

    public static readonly Latency Low = new("low");

    public static readonly Latency Standard = new("standard");

    public static Latency FromValue(string value) => FromValueCore(value);
}
