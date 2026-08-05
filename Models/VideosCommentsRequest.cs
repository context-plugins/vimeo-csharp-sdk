using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosCommentsRequest
{
    /// <summary>
    /// The rich comment in JSON stringified form. Either this field or the <b>text</b> field is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("richtext")]
    public string? Richtext { get; init; }

    /// <summary>
    /// The comment as plain text. Either this field or the <b>richtext</b> field is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public string? Text { get; init; }
}
