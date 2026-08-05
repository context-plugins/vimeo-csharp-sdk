using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The streaming type of the video.
/// <para>
/// Option descriptions:
///  * <c>live</c> - The video is streamed in real time.
///  * <c>non-live</c> - The video isn't streamed in real time.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StreamingType>))]
public sealed record StreamingType : StringEnum<StreamingType>
{
    private StreamingType(string value) : base(value)
    {
    }

    public static readonly StreamingType Live = new("live");

    public static readonly StreamingType NonLive = new("non-live");

    public static StreamingType FromValue(string value) => FromValueCore(value);
}
