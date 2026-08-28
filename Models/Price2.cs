using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Price2
{
    /// <summary>
    /// The purchase price of the video in Australian dollars.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AUD")]
    public double? Aud { get; init; }

    /// <summary>
    /// The purchase price of the video in Canadian dollars.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CAD")]
    public double? Cad { get; init; }

    /// <summary>
    /// The purchase price of the video in Swiss francs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CHF")]
    public double? Chf { get; init; }

    /// <summary>
    /// The purchase price of the video in Danish krone.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DKK")]
    public double? Dkk { get; init; }

    /// <summary>
    /// The purchase price of the video in euros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EUR")]
    public double? Eur { get; init; }

    /// <summary>
    /// The purchase price of the video in British pounds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("GBP")]
    public double? Gbp { get; init; }

    /// <summary>
    /// The purchase price of the video in Japanese yen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("JPY")]
    public double? Jpy { get; init; }

    /// <summary>
    /// The purchase price of the video in South Korean won.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("KRW")]
    public double? Krw { get; init; }

    /// <summary>
    /// The purchase price of the video in Norwegian krone.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("NOK")]
    public double? Nok { get; init; }

    /// <summary>
    /// The purchase price of the video in Polish zloty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PLN")]
    public double? Pln { get; init; }

    /// <summary>
    /// The purchase price of the video in Swedish krona.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SEK")]
    public double? Sek { get; init; }

    /// <summary>
    /// When <b>type</b> is <c>film</c>, the purchase price of the video in United States dollars. When <b>type</b> is <c>series</c>, the purchase price of the entire collection in United States dollars.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("USD")]
    public double? Usd { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
