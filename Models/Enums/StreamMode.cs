using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The stream mode of the event.
/// <para>
/// Option descriptions:
///  * <c>live</c> - The stream is live playback.
///  * <c>record</c> - The stream is in record mode.
///  * <c>simulive</c> - The stream is scheduled media playback.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StreamMode>))]
public sealed record StreamMode : StringEnum<StreamMode>
{
    private StreamMode(string value) : base(value)
    {
    }

    public static readonly StreamMode Live = new("live");

    public static readonly StreamMode Record = new("record");

    public static readonly StreamMode Simulive = new("simulive");

    public static StreamMode FromValue(string value) => FromValueCore(value);
}
