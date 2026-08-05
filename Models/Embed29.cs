using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Embed29
{
    /// <summary>
    /// Whether AirPlay is enabled in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airplay")]
    public bool? Airplay { get; init; }

    /// <summary>
    /// Whether multiple audio tracks can appear in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("audio_tracks")]
    public bool? AudioTracks { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buttons")]
    public Buttons8? Buttons { get; init; }

    /// <summary>
    /// A collection of cards associated with the selected video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cards")]
    public IReadOnlyList<Card2>? Cards { get; init; }

    /// <summary>
    /// Whether clicking the closed-captions button reveals the caption-language menu in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cc_track_menu")]
    public bool? CcTrackMenu { get; init; }

    /// <summary>
    /// Whether chapters are enabled in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chapters")]
    public bool? Chapters { get; init; }

    /// <summary>
    /// Whether the Chromecast button appears in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chromecast")]
    public bool? Chromecast { get; init; }

    /// <summary>
    /// Whether closed captions are enabled in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("closed_captions")]
    public bool? ClosedCaptions { get; init; }

    /// <summary>
    /// The main color of the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color")]
    public string? Color { get; init; }

    /// <summary>
    /// Whether the right-click context menu appears in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("context_menu")]
    public bool? ContextMenu { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_screen")]
    public EndScreen4? EndScreen { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logos")]
    public Logos16? Logos { get; init; }

    /// <summary>
    /// An object representing the play button's settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("play_button")]
    public PlayButton3? PlayButton { get; init; }

    /// <summary>
    /// Whether to show the playbar on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("playbar")]
    public bool? Playbar { get; init; }

    /// <summary>
    /// Whether to show the quality selector in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quality_selector")]
    public bool? QualitySelector { get; init; }

    /// <summary>
    /// A collection of sentiment widget configurations for the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sentiment_widgets")]
    public IReadOnlyList<SentimentWidget1>? SentimentWidgets { get; init; }

    /// <summary>
    /// Whether users can skip forward in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skipping_forward")]
    public bool? SkippingForward { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public Title2? Title { get; init; }

    /// <summary>
    /// Whether the transcript controls appear in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transcript")]
    public bool? Transcript { get; init; }

    /// <summary>
    /// Whether to show the volume selector on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume")]
    public bool? Volume { get; init; }
}
