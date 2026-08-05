using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the owner of the personal team folder.
/// </summary>
public record PersonalTeamFolderOwner
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The URI of the owner of the personal team folder.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}
