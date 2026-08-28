using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// An array of accepted currencies.
/// <para>
/// Option descriptions:
///  * <c>AUD</c> - The currency is in Australian dollars.
///  * <c>CAD</c> - The currency is in Canadian dollars.
///  * <c>CHF</c> - The currency is in Swiss francs.
///  * <c>DKK</c> - The currency is in Danish krone.
///  * <c>EUR</c> - The currency is in euros.
///  * <c>GBP</c> - The currency is in British pounds.
///  * <c>JPY</c> - The currency is in Japanese yen.
///  * <c>KRW</c> - The currency is in South Korean won.
///  * <c>NOK</c> - The currency is in Norwegian krone.
///  * <c>PLN</c> - The currency is in Polish zloty.
///  * <c>SEK</c> - The currency is in Swedish krona.
///  * <c>USD</c> - The currency is in United States dollars.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AcceptedCurrencies>))]
public sealed record AcceptedCurrencies : StringEnum<AcceptedCurrencies>
{
    private AcceptedCurrencies(string value) : base(value)
    {
    }

    public static readonly AcceptedCurrencies Aud = new("AUD");

    public static readonly AcceptedCurrencies Cad = new("CAD");

    public static readonly AcceptedCurrencies Chf = new("CHF");

    public static readonly AcceptedCurrencies Dkk = new("DKK");

    public static readonly AcceptedCurrencies Eur = new("EUR");

    public static readonly AcceptedCurrencies Gbp = new("GBP");

    public static readonly AcceptedCurrencies Jpy = new("JPY");

    public static readonly AcceptedCurrencies Krw = new("KRW");

    public static readonly AcceptedCurrencies Nok = new("NOK");

    public static readonly AcceptedCurrencies Pln = new("PLN");

    public static readonly AcceptedCurrencies Sek = new("SEK");

    public static readonly AcceptedCurrencies Usd = new("USD");

    public static AcceptedCurrencies FromValue(string value) => FromValueCore(value);
}
