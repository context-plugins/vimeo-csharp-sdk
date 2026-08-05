using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Credit
{
    /// <summary>
    /// The name of the person credited.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The character that the person portrayed, or the job that the person performed.
    /// </summary>
    [JsonPropertyName("role")]
    public required string Role { get; init; }

    /// <summary>
    /// The unique identifier to access the credit resource.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The Vimeo user associated with the credit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public User? User { get; init; }

    /// <summary>
    /// The video associated with the credit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("video")]
    public Video? Video { get; init; }
}
