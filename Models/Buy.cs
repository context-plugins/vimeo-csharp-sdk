using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The Buy interaction for the On Demand video.
/// </summary>
public record Buy
{
    /// <summary>
    /// The currency code for the user's region.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string? Currency { get; init; }

    /// <summary>
    /// The formatted display price for buying the On Demand video.
    /// </summary>
    [JsonPropertyName("display_price")]
    public required string? DisplayPrice { get; init; }

    /// <summary>
    /// The user's download access to the On Demand video.
    /// <para>
    /// Option descriptions:
    ///  * <c>available</c> - The video is available for download.
    ///  * <c>purchased</c> - The user has purchased the video.
    ///  * <c>restricted</c> - The user isn't permitted to download the video.
    ///  * <c>unavailable</c> - The video isn't available for download.
    /// </para>
    /// </summary>
    [JsonPropertyName("download")]
    public required Download Download { get; init; }

    /// <summary>
    /// Whether the On Demand video has DRM.
    /// </summary>
    [JsonPropertyName("drm")]
    public required bool Drm { get; init; }

    /// <summary>
    /// The URL to buy the On Demand video on Vimeo.
    /// </summary>
    [JsonPropertyName("link")]
    public required string? Link { get; init; }

    /// <summary>
    /// The price to buy the On Demand video.
    /// </summary>
    [JsonPropertyName("price")]
    public required double? Price { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the On Demand video was purchased.
    /// </summary>
    [JsonPropertyName("purchase_time")]
    public required string? PurchaseTime { get; init; }

    /// <summary>
    /// The user's streaming access to the On Demand video.
    /// <para>
    /// Option descriptions:
    ///  * <c>available</c> - The video is available for streaming.
    ///  * <c>purchased</c> - The user has purchased the video.
    ///  * <c>restricted</c> - The user isn't permitted to stream the video.
    ///  * <c>unavailable</c> - The video isn't available for streaming
    /// </para>
    /// </summary>
    [JsonPropertyName("stream")]
    public required StreamEnum Stream { get; init; }

    /// <summary>
    /// The product URI to purchase the On Demand video.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string? Uri { get; init; }
}
