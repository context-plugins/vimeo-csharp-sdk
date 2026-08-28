using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The language in which the automated closed captions appear.
/// <para>
/// Option descriptions:
///  * <c>de-DE</c> - The language is German.
///  * <c>en-US</c> - The language is English.
///  * <c>es-ES</c> - The language is Spanish.
///  * <c>fr-FR</c> - The language is French.
///  * <c>pt-BR</c> - The language is Portuguese.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AutoCcLang>))]
public sealed record AutoCcLang : StringEnum<AutoCcLang>
{
    private AutoCcLang(string value) : base(value)
    {
    }

    public static readonly AutoCcLang DeDe = new("de-DE");

    public static readonly AutoCcLang EnUs = new("en-US");

    public static readonly AutoCcLang EsEs = new("es-ES");

    public static readonly AutoCcLang FrFr = new("fr-FR");

    public static readonly AutoCcLang PtBr = new("pt-BR");

    public static AutoCcLang FromValue(string value) => FromValueCore(value);
}
