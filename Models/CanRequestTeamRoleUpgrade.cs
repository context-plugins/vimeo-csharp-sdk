using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about whether the user can request a team upgrade from the Viewer role.
/// </summary>
public record CanRequestTeamRoleUpgrade
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// An object of suggested fields to be used for this interaction.
    /// </summary>
    [JsonPropertyName("properties")]
    public required Properties Properties { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}
