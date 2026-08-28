using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Domain
{
    /// <summary>
    /// Whether to permit HD embeds on this domain.
    /// </summary>
    [JsonPropertyName("allow_hd")]
    public required bool AllowHd { get; init; }

    /// <summary>
    /// The domain name.
    /// </summary>
    [JsonPropertyName("domain")]
    public required string DomainValue { get; init; }

    /// <summary>
    /// The URI of the domain.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
