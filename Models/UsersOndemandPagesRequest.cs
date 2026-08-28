using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record UsersOndemandPagesRequest
{
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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accepted_currencies")]
    public AcceptedCurrencies? AcceptedCurrencies { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy")]
    public Buy3? Buy { get; init; }

    /// <summary>
    /// The content rating of the video, given either as a comma-separated list or as a JSON array, depending on the request format.
    /// <para>
    /// Option descriptions:
    ///  * <c>drugs</c> - The video contains drug or alcohol use.
    ///  * <c>language</c> - The video contains profanity or sexually suggestive content.
    ///  * <c>nudity</c> - The video contains nudity.
    ///  * <c>safe</c> - The video is suitable for all audiences.
    ///  * <c>unrated</c> - The video hasn't been rated.
    ///  * <c>violence</c> - The video contains violent or graphic content.
    /// </para>
    /// </summary>
    [JsonPropertyName("content_rating")]
    public required ContentRating1 ContentRating { get; init; }

    /// <summary>
    /// The description of the On Demand page.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The custom domain of the On Demand page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domain_link")]
    public string? DomainLink { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("episodes")]
    public Episodes1? Episodes { get; init; }

    /// <summary>
    /// The custom string to use in the Vimeo URL of the On Demand page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }

    /// <summary>
    /// The name of the On Demand page.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rent")]
    public Rent4? Rent { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscription")]
    public Subscription2? Subscription { get; init; }

    /// <summary>
    /// The type of the On Demand page.
    /// <para>
    /// Option descriptions:
    ///  * <c>film</c> - The On Demand page is a film.
    ///  * <c>series</c> - The On Demand page is a series.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type37 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
