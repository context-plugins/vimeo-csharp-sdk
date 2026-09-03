using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record TextDecoration
{
    /// <summary>
    /// The assets that are needed to decorate the text.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assets")]
    public Assets? Assets { get; init; }

    /// <summary>
    /// The note text to decorate.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    /// <summary>
    /// The type of text decoration.
    /// <para>
    /// Option descriptions:
    ///  * <c>url</c> - The URL of the Vimeo video.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "url";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
