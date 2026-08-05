using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the team user who uploaded the video. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record ResourceCreatorTeamUser
{
    /// <summary>
    /// The URI for the team user who uploaded the video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}
