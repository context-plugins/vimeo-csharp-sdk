using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The status of the team membership invite.
/// <para>
/// Option descriptions:
///  * <c>accepted</c> - Team membership has been accepted.
///  * <c>pending</c> - Team membership has been offered but not yet accepted.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status21>))]
public sealed record Status21 : StringEnum<Status21>
{
    private Status21(string value) : base(value)
    {
    }

    public static readonly Status21 Accepted = new("accepted");

    public static readonly Status21 Pending = new("pending");

    public static Status21 FromValue(string value) => FromValueCore(value);
}
