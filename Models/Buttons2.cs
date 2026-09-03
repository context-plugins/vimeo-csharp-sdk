using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Buttons2
{
    /// <summary>
    /// Whether to show the button for embeds on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed")]
    public bool? Embed { get; init; }

    /// <summary>
    /// Whether to show the button for fullscreen mode on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullscreen")]
    public bool? Fullscreen { get; init; }

    /// <summary>
    /// Whether to show the button for HD videos on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hd")]
    public bool? Hd { get; init; }

    /// <summary>
    /// Whether to show the button for likes on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("like")]
    public bool? Like { get; init; }

    /// <summary>
    /// Whether to show the button for scaling on the embeddable player in fullscreen mode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaling")]
    public bool? Scaling { get; init; }

    /// <summary>
    /// Whether to show the button for shares on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("share")]
    public bool? Share { get; init; }

    /// <summary>
    /// Whether to show the button for watching later on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("watchlater")]
    public bool? Watchlater { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
