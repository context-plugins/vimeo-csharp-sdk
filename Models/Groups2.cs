using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A standard connection object indicating how to return groups that this team user is a part of.
/// </summary>
public record Groups2
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
