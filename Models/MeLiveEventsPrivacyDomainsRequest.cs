using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record MeLiveEventsPrivacyDomainsRequest
{
    /// <summary>
    /// An array of the domains on which the embedded event can appear.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed_domains")]
    public IReadOnlyList<string>? AllowedDomains { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
