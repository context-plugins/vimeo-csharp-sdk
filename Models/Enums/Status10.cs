using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The status of the pre-live video's RTMP link.
/// <para>
/// Option descriptions:
///  * <c>pending</c> - Vimeo is working on setting up the connection.
///  * <c>ready</c> - Resources have been provisioned for the event.
///  * <c>streaming</c> - Live video is currently streaming to the RTMP link.
///  * <c>unavailable</c> - The connection is ready, but streaming to the RTMP link has not yet begun.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status10>))]
public sealed record Status10 : StringEnum<Status10>
{
    private Status10(string value) : base(value)
    {
    }

    public static readonly Status10 Pending = new("pending");

    public static readonly Status10 Ready = new("ready");

    public static readonly Status10 Streaming = new("streaming");

    public static readonly Status10 Unavailable = new("unavailable");

    public static Status10 FromValue(string value) => FromValueCore(value);
}
