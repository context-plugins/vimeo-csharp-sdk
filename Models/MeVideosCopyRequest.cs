using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record MeVideosCopyRequest
{
    /// <summary>
    /// The copied video name. By default, this becomes the source video name with (Copy) appended.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
