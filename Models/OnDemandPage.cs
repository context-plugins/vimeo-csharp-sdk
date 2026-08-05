using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record OnDemandPage
{
    /// <summary>
    /// The background image for the On Demand page.
    /// </summary>
    [JsonPropertyName("background")]
    public required Picture? Background { get; init; }

    /// <summary>
    /// The first and second colors of the On Demand page.
    /// </summary>
    [JsonPropertyName("colors")]
    public required Colors2 Colors { get; init; }

    /// <summary>
    /// An array of the On Demand page's content ratings.
    /// </summary>
    [JsonPropertyName("content_rating")]
    public required IReadOnlyList<string> ContentRating { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the On Demand page was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_time")]
    public string? CreatedTime { get; init; }

    /// <summary>
    /// The description of the On Demand page.
    /// </summary>
    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    /// <summary>
    /// The link to the On Demand page on its own domain.
    /// </summary>
    [JsonPropertyName("domain_link")]
    public required string? DomainLink { get; init; }

    /// <summary>
    /// Information about the On Demand page's episodes, if the page is for a series.
    /// </summary>
    [JsonPropertyName("episodes")]
    public required Episodes Episodes { get; init; }

    /// <summary>
    /// The On Demand page's film, if the page is for a film.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("film")]
    public Video? Film { get; init; }

    /// <summary>
    /// An array of the genres assigned to the On Demand page.
    /// </summary>
    [JsonPropertyName("genres")]
    public required IReadOnlyList<OnDemandGenre> Genres { get; init; }

    /// <summary>
    /// The link to the On Demand page.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// Metadata about the On Demand page.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata9 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the On Demand page was last modified.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modified_time")]
    public string? ModifiedTime { get; init; }

    /// <summary>
    /// The descriptive title of the On Demand page.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The active poster for the On Demand page.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture? Pictures { get; init; }

    [JsonPropertyName("preorder")]
    public required Preorder Preorder { get; init; }

    [JsonPropertyName("published")]
    public required Published Published { get; init; }

    /// <summary>
    /// The rating of the On Demand page.
    /// </summary>
    [JsonPropertyName("rating")]
    public required double? Rating { get; init; }

    /// <summary>
    /// The On Demand resource key.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// The creator-designated SKU for the On Demand page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sku")]
    public string? Sku { get; init; }

    /// <summary>
    /// Information about subscribing to the On Demand page, if subscription is enabled.
    /// </summary>
    [JsonPropertyName("subscription")]
    public required Subscription1? Subscription { get; init; }

    /// <summary>
    /// The graphical theme for the On Demand page.
    /// </summary>
    [JsonPropertyName("theme")]
    public required string Theme { get; init; }

    /// <summary>
    /// The thumbnail image for the On Demand page.
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public required Picture? Thumbnail { get; init; }

    /// <summary>
    /// The trailer for the On Demand page.
    /// </summary>
    [JsonPropertyName("trailer")]
    public required Video? Trailer { get; init; }

    /// <summary>
    /// The type of the On Demand page.
    /// <para>
    /// Option descriptions:
    ///  * <c>film</c> - The On Demand page is for a film.
    ///  * <c>series</c> - The On Demand page is for a series.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type9 Type { get; init; }

    /// <summary>
    /// The relative URI of the On Demand page.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The user who created the On Demand page.
    /// </summary>
    [JsonPropertyName("user")]
    public required User? User { get; init; }
}
