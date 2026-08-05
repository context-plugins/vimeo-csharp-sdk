using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosCommentsRepliesRequest
{
    /// <summary>
    /// The rich comment in JSON stringified form.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("richtext")]
    public string? Richtext { get; init; }

    /// <summary>
    /// The reply to the comment.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }
}
