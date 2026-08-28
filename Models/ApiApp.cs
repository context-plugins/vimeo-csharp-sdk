using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record ApiApp
{
    /// <summary>
    /// The app's capabilities list.
    /// </summary>
    [JsonPropertyName("capabilities")]
    public required object Capabilities { get; init; }

    /// <summary>
    /// The name of the API app.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The canonical URI of the API app.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
