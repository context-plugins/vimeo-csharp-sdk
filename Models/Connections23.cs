using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// A list of resource URIs related to the item.
/// </summary>
public record Connections23
{
    /// <summary>
    /// Information about the team of the shared item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shared_team")]
    public SharedTeam? SharedTeam { get; init; }

    /// <summary>
    /// Information about the user who shared the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shared_user")]
    public SharedUser? SharedUser { get; init; }
}
