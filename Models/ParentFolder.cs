using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// A standard connection object indicating how to return the folder's parent folder.
/// </summary>
public record ParentFolder
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}
