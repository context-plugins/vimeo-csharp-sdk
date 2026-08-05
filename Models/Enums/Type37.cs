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
[JsonConverter(typeof(StringEnumConverter<Type37>))]
public sealed record Type37 : StringEnum<Type37>
{
    private Type37(string value) : base(value)
    {
    }

    public static readonly Type37 Film = new("film");

    public static readonly Type37 Series = new("series");

    public static Type37 FromValue(string value) => FromValueCore(value);
}
