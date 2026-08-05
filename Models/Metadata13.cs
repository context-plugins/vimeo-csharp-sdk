using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Metadata13
{
    [JsonPropertyName("connections")]
    public required Connections13 Connections { get; init; }

    /// <summary>
    /// An object containing the actions that the user can perform on the comment.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required Interactions8 Interactions { get; init; }
}
