using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The language of the automated closed captions.
/// <para>
/// Option descriptions:
///  * <c>de-DE</c> - The language is German.
///  * <c>en-US</c> - The language is English.
///  * <c>es-ES</c> - The language is Spanish.
///  * <c>fr-FR</c> - The language is French.
///  * <c>pt-BR</c> - The language is Portuguese.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AutoCcLanguage2>))]
public sealed record AutoCcLanguage2 : StringEnum<AutoCcLanguage2>
{
    private AutoCcLanguage2(string value) : base(value)
    {
    }

    public static readonly AutoCcLanguage2 DeDe = new("de-DE");

    public static readonly AutoCcLanguage2 EnUs = new("en-US");

    public static readonly AutoCcLanguage2 EsEs = new("es-ES");

    public static readonly AutoCcLanguage2 FrFr = new("fr-FR");

    public static readonly AutoCcLanguage2 PtBr = new("pt-BR");

    public static AutoCcLanguage2 FromValue(string value) => FromValueCore(value);
}
