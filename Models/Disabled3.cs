using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Whether the publish-to-social feature is disabled.
/// </summary>
public record Disabled3
{
    /// <summary>
    /// The link to re-enable the publish-to-social feature.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enable_link")]
    public string? EnableLink { get; init; }

    /// <summary>
    /// The reasons why publish-to-social presets are disabled for the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasons")]
    public IReadOnlyList<Reason2>? Reasons { get; init; }
}
