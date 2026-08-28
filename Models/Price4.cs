using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Price4
{
    /// <summary>
    /// The rental price per episode in United States dollars. This parameter is applicable only when <b>type</b> is <c>series</c>, and it's required when <b>episode.rent.active</b> is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("USD")]
    public double? Usd { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
