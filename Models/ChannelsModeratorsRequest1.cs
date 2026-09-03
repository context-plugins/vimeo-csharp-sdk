using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record ChannelsModeratorsRequest1
{
    /// <summary>
    /// The URI of the user to add as a moderator.
    /// </summary>
    [JsonPropertyName("user_uri")]
    public required string UserUri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
