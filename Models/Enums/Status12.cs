using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Status12>))]
public sealed record Status12 : StringEnum<Status12>
{
    private Status12(string value) : base(value)
    {
    }

    public static readonly Status12 Pending = new("pending");

    public static readonly Status12 Ready = new("ready");

    public static readonly Status12 Streaming = new("streaming");

    public static readonly Status12 Unavailable = new("unavailable");

    public static Status12 FromValue(string value) => FromValueCore(value);
}
