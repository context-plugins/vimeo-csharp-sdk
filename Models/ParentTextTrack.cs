using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Metadata for the parent text track.
/// </summary>
public record ParentTextTrack
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public IReadOnlyList<string>? Options { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }
}
