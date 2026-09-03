using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Embed data for the showcase.
/// </summary>
public record Embed2
{
    /// <summary>
    /// The responsive HTML code to embed the showcase's playlist on a website. This field appears only when the showcase has embeddable videos.
    /// </summary>
    [JsonPropertyName("html")]
    public required string? Html { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
