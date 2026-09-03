using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The widget variant.
/// <para>
/// Option descriptions:
///  * <c>ranking</c> - The widget shows a ranking of options.
///  * <c>thumbs</c> - The widget shows thumbs up/down buttons.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type50>))]
public sealed record Type50 : StringEnum<Type50>
{
    private Type50(string value) : base(value)
    {
    }

    public static readonly Type50 Ranking = new("ranking");

    public static readonly Type50 Thumbs = new("thumbs");

    public static Type50 FromValue(string value) => FromValueCore(value);
}
