using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Subscription2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly")]
    public Monthly? Monthly { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
