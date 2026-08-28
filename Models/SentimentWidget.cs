using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record SentimentWidget
{
    /// <summary>
    /// The playback position in seconds when the widget disappears.
    /// </summary>
    [JsonPropertyName("end_time")]
    public required double EndTime { get; init; }

    /// <summary>
    /// The headline text shown above the widget.
    /// </summary>
    [JsonPropertyName("headline")]
    public required string Headline { get; init; }

    /// <summary>
    /// The unique identifier of the sentiment widget.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The playback position in seconds when the widget appears.
    /// </summary>
    [JsonPropertyName("start_time")]
    public required double StartTime { get; init; }

    /// <summary>
    /// The widget variant: <c>thumbs</c> or <c>ranking</c>.
    /// <para>
    /// Option descriptions:
    ///  * <c>ranking</c> - The widget shows a ranking of options.
    ///  * <c>thumbs</c> - The widget shows thumbs up/down buttons.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type5 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
