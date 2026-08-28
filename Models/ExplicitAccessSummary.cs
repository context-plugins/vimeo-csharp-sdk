using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// The explicit access summary of the video. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record ExplicitAccessSummary
{
    /// <summary>
    /// The number of direct access grants for all teams. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("all_team_count")]
    public double? AllTeamCount { get; init; }

    /// <summary>
    /// The number of direct access grants for team groups. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_group_count")]
    public double? TeamGroupCount { get; init; }

    /// <summary>
    /// The number of direct access grants for team users. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_user_count")]
    public double? TeamUserCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
