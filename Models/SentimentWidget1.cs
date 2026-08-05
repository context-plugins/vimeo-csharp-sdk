using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record SentimentWidget1
{
    /// <summary>
    /// The playback position in seconds when the widget disappears.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public double? EndTime { get; init; }

    /// <summary>
    /// The headline text shown above the widget.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headline")]
    public string? Headline { get; init; }

    /// <summary>
    /// The unique identifier of the sentiment widget.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The playback position in seconds when the widget appears.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_time")]
    public double? StartTime { get; init; }

    /// <summary>
    /// The widget variant.
    /// <para>
    /// Option descriptions:
    ///  * <c>ranking</c> - The widget shows a ranking of options.
    ///  * <c>thumbs</c> - The widget shows thumbs up/down buttons.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type54? Type { get; init; }
}
