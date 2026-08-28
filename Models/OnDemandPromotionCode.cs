using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record OnDemandPromotionCode
{
    /// <summary>
    /// The Vimeo promotion code.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// The link to redeem the promotion code.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The total number of times that this code can be used.
    /// </summary>
    [JsonPropertyName("max_uses")]
    public required double MaxUses { get; init; }

    /// <summary>
    /// The current number of times that this code has been used.
    /// </summary>
    [JsonPropertyName("uses")]
    public required double Uses { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
