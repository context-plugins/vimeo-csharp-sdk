using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Report2
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// A list of predefined reasons for which the comment can be reported. These reasons correspond to the available flagging options.
    /// </summary>
    [JsonPropertyName("reason")]
    public required IReadOnlyList<string> Reason { get; init; }

    /// <summary>
    /// The URI to use for sending a report request for the comment.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}
