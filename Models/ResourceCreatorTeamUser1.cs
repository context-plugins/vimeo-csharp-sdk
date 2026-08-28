using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about the team user who created the folder. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record ResourceCreatorTeamUser1
{
    /// <summary>
    /// The URI for the team user who created the folder. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
