using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// Information on subscribing to the On Demand video.
/// </summary>
public record Subscribe1
{
    /// <summary>
    /// Whether the On Demand subscription has DRM.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("drm")]
    public bool? Drm { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the On Demand video expires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_time")]
    public string? ExpiresTime { get; init; }

    /// <summary>
    /// The URL to purchase the On Demand subscription on Vimeo.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the On Demand video was purchased.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchase_time")]
    public string? PurchaseTime { get; init; }

    /// <summary>
    /// The user's streaming access to the On Demand subscription.
    /// <para>
    /// Option descriptions:
    ///  * <c>available</c> - The On Demand subscription is available for streaming.
    ///  * <c>purchased</c> - The On Demand subscription has been purchased.
    ///  * <c>restricted</c> - Streaming for the On Demand subscription is restricted.
    ///  * <c>unavailable</c> - The On Demand subscription is unavailable.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stream")]
    public Stream2? Stream { get; init; }

    /// <summary>
    /// The On Demand subscription's product URI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
