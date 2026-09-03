using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// What to do with the outro.
/// <para>
/// Option descriptions:
///  * <c>nothing</c> - Disable the outro.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Outro1>))]
public sealed record Outro1 : StringEnum<Outro1>
{
    private Outro1(string value) : base(value)
    {
    }

    public static readonly Outro1 Nothing = new("nothing");

    public static Outro1 FromValue(string value) => FromValueCore(value);
}
