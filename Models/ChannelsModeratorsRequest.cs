using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record ChannelsModeratorsRequest
{
    /// <summary>
    /// The URI of a user to remove as a moderator.
    /// </summary>
    [JsonPropertyName("user_uri")]
    public required string UserUri { get; init; }
}
