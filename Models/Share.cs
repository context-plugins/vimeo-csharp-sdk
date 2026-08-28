using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The share options that appear after the video ends.
/// </summary>
public record Share
{
    /// <summary>
    /// The image to display behind the share options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("picture")]
    public Picture? Picture { get; init; }

    /// <summary>
    /// The URI of the background image that appears behind the share options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("picture_uri")]
    public string? PictureUri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
