using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The authenticated user's metadata.
/// </summary>
public record Metadata3
{
    /// <summary>
    /// The list of resource URIs related to the authenticated user.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections3 Connections { get; init; }

    [JsonPropertyName("interactions")]
    public required Interactions2 Interactions { get; init; }

    /// <summary>
    /// Information about the Microsoft Teams encrypted team ID.
    /// </summary>
    [JsonPropertyName("ms_teams_encrypted_team_id")]
    public required string? MsTeamsEncryptedTeamId { get; init; }

    [JsonPropertyName("public_videos")]
    public required PublicVideos PublicVideos { get; init; }
}
