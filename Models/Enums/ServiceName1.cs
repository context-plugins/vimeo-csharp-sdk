using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The service to simulcast to.
/// <para>
/// Option descriptions:
///  * <c>custom_rtmp</c> - Simulcast to a custom service.
///  * <c>facebook</c> - Simulcast to Facebook Live.
///  * <c>linkedin</c> - Simulcast to LinkedIn Live.
///  * <c>youtube</c> - Simulcast to YouTube Live.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceName1>))]
public sealed record ServiceName1 : StringEnum<ServiceName1>
{
    private ServiceName1(string value) : base(value)
    {
    }

    public static readonly ServiceName1 CustomRtmp = new("custom_rtmp");

    public static readonly ServiceName1 Facebook = new("facebook");

    public static readonly ServiceName1 Linkedin = new("linkedin");

    public static readonly ServiceName1 Youtube = new("youtube");

    public static ServiceName1 FromValue(string value) => FromValueCore(value);
}
