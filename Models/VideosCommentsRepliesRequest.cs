using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
