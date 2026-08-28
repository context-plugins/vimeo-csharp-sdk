using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The widget variant.
/// <para>
/// Option descriptions:
///  * <c>ranking</c> - The widget shows a ranking of options.
///  * <c>thumbs</c> - The widget shows thumbs up/down buttons.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type54>))]
public sealed record Type54 : StringEnum<Type54>
{
    private Type54(string value) : base(value)
    {
    }

    public static readonly Type54 Ranking = new("ranking");

    public static readonly Type54 Thumbs = new("thumbs");

    public static Type54 FromValue(string value) => FromValueCore(value);
}
