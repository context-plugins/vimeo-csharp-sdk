using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The ingest status of the live video.
/// <para>
/// Option descriptions:
///  * <c>0</c> - There’s a live video, but no RMTP URL or key.
///  * <c>1</c> - There’s an RMTP URL and key, but the machine is provisioning.
///  * <c>2</c> - There’s an RMTP URL and key, and the machine is provisioned, but the stream hasn’t started yet.
///  * <c>3</c> - There’s an RMTP URL and key, and the machine is provisioned, but the stream didn’t start before the machine timed out.
///  * <c>4</c> - The stream has started and is currently underway.
///  * <c>5</c> - The stream has ended.
/// </para>
/// </summary>
[JsonConverter(typeof(IntEnumConverter<Status14>))]
public sealed record Status14 : IntEnum<Status14>
{
    private Status14(int value) : base(value)
    {
    }

    public static readonly Status14 Value0 = new(0);

    public static readonly Status14 Value1 = new(1);

    public static readonly Status14 Value2 = new(2);

    public static readonly Status14 Value3 = new(3);

    public static readonly Status14 Value4 = new(4);

    public static readonly Status14 Value5 = new(5);

    public static Status14 FromValue(int value) => FromValueCore(value);
}
