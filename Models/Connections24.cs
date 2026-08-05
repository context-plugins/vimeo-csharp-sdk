using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// A list of resource URIs related to the user.
/// </summary>
public record Connections24
{
    /// <summary>
    /// A standard connection object indicating how to return groups that this team user is a part of.
    /// </summary>
    [JsonPropertyName("groups")]
    public required Groups2 Groups { get; init; }

    /// <summary>
    /// Information about the team owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public required Owner1 Owner { get; init; }

    /// <summary>
    /// A standard connection object indicating how to return personal team folders.
    /// </summary>
    [JsonPropertyName("personal_team_folder")]
    public required PersonalTeamFolder PersonalTeamFolder { get; init; }
}
