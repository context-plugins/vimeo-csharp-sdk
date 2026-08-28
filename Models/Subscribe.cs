using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Subscription information for an On Demand video.
/// </summary>
public record Subscribe
{
    /// <summary>
    /// Whether the On Demand video has DRM.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("drm")]
    public bool? Drm { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the subscription expires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires_time")]
    public string? ExpiresTime { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the subscription was purchased.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchase_time")]
    public string? PurchaseTime { get; init; }

    /// <summary>
    /// The stream type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stream")]
    public string? Stream { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
