using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of the On Demand page.
/// <para>
/// Option descriptions:
///  * <c>film</c> - The On Demand page is for a film.
///  * <c>series</c> - The On Demand page is for a series.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type9>))]
public sealed record Type9 : StringEnum<Type9>
{
    private Type9(string value) : base(value)
    {
    }

    public static readonly Type9 Film = new("film");

    public static readonly Type9 Series = new("series");

    public static Type9 FromValue(string value) => FromValueCore(value);
}
