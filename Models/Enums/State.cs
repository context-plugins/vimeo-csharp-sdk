using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The status of the destination.
/// <para>
/// Option descriptions:
///  * <c>0</c> - The status is OK.
///  * <c>1</c> - An error occurred. Check the <c>state_message</c> field for details.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<State>))]
public sealed record State : StringEnum<State>
{
    private State(string value) : base(value)
    {
    }

    public static readonly State _0 = new("0");

    public static readonly State _1 = new("1");

    public static State FromValue(string value) => FromValueCore(value);
}
