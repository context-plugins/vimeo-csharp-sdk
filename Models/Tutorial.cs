using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Tutorial
{
    /// <summary>
    /// The success message.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    /// <summary>
    /// The link to the next tutorial.
    /// </summary>
    [JsonPropertyName("next_steps_link")]
    public required string NextStepsLink { get; init; }

    /// <summary>
    /// Whether the current access token is authenticated.
    /// </summary>
    [JsonPropertyName("token_is_authenticated")]
    public required bool TokenIsAuthenticated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
