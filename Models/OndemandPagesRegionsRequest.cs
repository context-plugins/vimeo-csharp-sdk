using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record OndemandPagesRegionsRequest
{
    /// <summary>
    /// An array of country codes for the regions to remove.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countries")]
    public IReadOnlyList<string>? Countries { get; init; }
}
