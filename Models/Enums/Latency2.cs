using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of stream delay on the viewer side.
/// <para>
/// Option descriptions:
///  * <c>fail-safe</c> - The latency is in the failsafe range, with a delay of 60-75 seconds.
///  * <c>low</c> - The latency is low, with a delay of 5-7 seconds.
///  * <c>standard</c> - The latency is standard, with a delay of 15-20 seconds.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Latency2>))]
public sealed record Latency2 : StringEnum<Latency2>
{
    private Latency2(string value) : base(value)
    {
    }

    public static readonly Latency2 FailSafe = new("fail-safe");

    public static readonly Latency2 Low = new("low");

    public static readonly Latency2 Standard = new("standard");

    public static Latency2 FromValue(string value) => FromValueCore(value);
}
