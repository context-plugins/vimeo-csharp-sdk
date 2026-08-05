using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The name of the destination service.
/// <para>
/// Option descriptions:
///  * <c>custom_rtmp</c> - The destination service is custom RTMP.
///  * <c>facebook</c> - The destination service is Facebook Live.
///  * <c>linkedin</c> - The destination service is LinkedIn Live.
///  * <c>youtube</c> - The destination service is YouTube Live.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceName>))]
public sealed record ServiceName : StringEnum<ServiceName>
{
    private ServiceName(string value) : base(value)
    {
    }

    public static readonly ServiceName CustomRtmp = new("custom_rtmp");

    public static readonly ServiceName Facebook = new("facebook");

    public static readonly ServiceName Linkedin = new("linkedin");

    public static readonly ServiceName Youtube = new("youtube");

    public static ServiceName FromValue(string value) => FromValueCore(value);
}
