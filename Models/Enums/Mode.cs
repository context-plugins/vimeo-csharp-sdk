using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The team seats mode for the user's team.
/// <para>
/// Option descriptions:
///  * <c>admin_and_authenticated</c> - The mode for Enterprise-Base Platform, Enterprise-Marketing, and Enterprise-Central users.
///  * <c>global</c> - The default mode for legacy and self-serve users.
///  * <c>per_seat_type</c> - The mode for sales-assisted users, including Enterprise, Custom, and Custom OTT.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Mode>))]
public sealed record Mode : StringEnum<Mode>
{
    private Mode(string value) : base(value)
    {
    }

    public static readonly Mode AdminAndAuthenticated = new("admin_and_authenticated");

    public static readonly Mode Global = new("global");

    public static readonly Mode PerSeatType = new("per_seat_type");

    public static Mode FromValue(string value) => FromValueCore(value);
}
