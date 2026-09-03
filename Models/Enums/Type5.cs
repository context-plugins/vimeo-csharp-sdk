using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The widget variant: <c>thumbs</c> or <c>ranking</c>.
/// <para>
/// Option descriptions:
///  * <c>ranking</c> - The widget shows a ranking of options.
///  * <c>thumbs</c> - The widget shows thumbs up/down buttons.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type5>))]
public sealed record Type5 : StringEnum<Type5>
{
    private Type5(string value) : base(value)
    {
    }

    public static readonly Type5 Ranking = new("ranking");

    public static readonly Type5 Thumbs = new("thumbs");

    public static Type5 FromValue(string value) => FromValueCore(value);
}
