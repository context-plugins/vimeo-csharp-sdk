using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The status of the live video's RTMP link.
/// <para>
/// Option descriptions:
///  * <c>streaming</c> - The stream is open and receiving content.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status11>))]
public sealed record Status11 : StringEnum<Status11>
{
    private Status11(string value) : base(value)
    {
    }

    public static readonly Status11 Streaming = new("streaming");

    public static Status11 FromValue(string value) => FromValueCore(value);
}
