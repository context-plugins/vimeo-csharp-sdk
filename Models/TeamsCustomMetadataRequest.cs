using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record TeamsCustomMetadataRequest
{
    /// <summary>
    /// The custom metadata fields to create, update, or delete.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fields")]
    public IReadOnlyList<Field>? Fields { get; init; }
}
