using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The availability of the animated thumbnail.
/// <para>
/// Option descriptions:
///  * <c>cancelled</c> - The animated thumbnail's creation has been cancelled.
///  * <c>completed</c> - The animated thumbnail has been created.
///  * <c>failed</c> - The animated thumbnail's creation has failed.
///  * <c>started</c> - The animated thumbnail's creation has started.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status9>))]
public sealed record Status9 : StringEnum<Status9>
{
    private Status9(string value) : base(value)
    {
    }

    public static readonly Status9 Cancelled = new("cancelled");

    public static readonly Status9 Completed = new("completed");

    public static readonly Status9 Failed = new("failed");

    public static readonly Status9 Started = new("started");

    public static Status9 FromValue(string value) => FromValueCore(value);
}
