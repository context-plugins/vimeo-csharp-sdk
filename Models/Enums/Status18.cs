using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The status of the team membership invite.
/// <para>
/// Option descriptions:
///  * <c>accepted</c> - Team membership has been accepted.
///  * <c>pending</c> - Team membership has been offered but not yet accepted.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status18>))]
public sealed record Status18 : StringEnum<Status18>
{
    private Status18(string value) : base(value)
    {
    }

    public static readonly Status18 Accepted = new("accepted");

    public static readonly Status18 Pending = new("pending");

    public static Status18 FromValue(string value) => FromValueCore(value);
}
