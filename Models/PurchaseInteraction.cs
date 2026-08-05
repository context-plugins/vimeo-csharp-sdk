using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record PurchaseInteraction
{
    /// <summary>
    /// Information on purchasing the On Demand video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy")]
    public object? Buy { get; init; }

    /// <summary>
    /// Information on renting the On Demand video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rent")]
    public object? Rent { get; init; }

    /// <summary>
    /// Information on subscribing to the On Demand video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscribe")]
    public Subscribe1? Subscribe { get; init; }
}
