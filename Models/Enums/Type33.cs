using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of the On Demand page.
/// <para>
/// Option descriptions:
///  * <c>film</c> - The On Demand page is a film.
///  * <c>series</c> - The On Demand page is a series.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type33>))]
public sealed record Type33 : StringEnum<Type33>
{
    private Type33(string value) : base(value)
    {
    }

    public static readonly Type33 Film = new("film");

    public static readonly Type33 Series = new("series");

    public static Type33 FromValue(string value) => FromValueCore(value);
}
