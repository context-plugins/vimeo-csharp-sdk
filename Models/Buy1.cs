using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Buy1
{
    /// <summary>
    /// Whether all the videos on the On Demand page can be purchased as a whole.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// The default price to buy an episode.
    /// </summary>
    [JsonPropertyName("price")]
    public required double? Price { get; init; }
}
