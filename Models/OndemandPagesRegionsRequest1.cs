using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record OndemandPagesRegionsRequest1
{
    /// <summary>
    /// An array of country codes for the regions to add.
    /// </summary>
    [JsonPropertyName("countries")]
    public required IReadOnlyList<string> Countries { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
