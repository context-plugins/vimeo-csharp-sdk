using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record HlsDashVideoFile
{
    /// <summary>
    /// The direct link to the video file.
    /// </summary>
    [JsonPropertyName("link")]
    public required string? Link { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the link to the video file expires.
    /// </summary>
    [JsonPropertyName("link_expiration_time")]
    public required string LinkExpirationTime { get; init; }

    /// <summary>
    /// The URL for logging events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("log")]
    public string? Log { get; init; }
}
