using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record OndemandPagesPicturesRequest
{
    /// <summary>
    /// Whether this poster is the one that appears on the On Demand page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}
