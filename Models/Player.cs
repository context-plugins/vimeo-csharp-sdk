using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// The contents of the player group.
/// </summary>
public record Player
{
    /// <summary>
    /// Whether AirPlay is enabled in the video page player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airplay")]
    public bool? Airplay { get; init; }

    /// <summary>
    /// Whether multiple audio tracks can appear in the video page player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("audio_tracks")]
    public bool? AudioTracks { get; init; }

    /// <summary>
    /// Whether the video automatically plays for viewers without their own autoplay preference (e.g. logged-out visitors).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("autoplay")]
    public bool? Autoplay { get; init; }

    /// <summary>
    /// Whether clicking the closed-captions button reveals the caption-language menu in the video page player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cc_track_menu")]
    public bool? CcTrackMenu { get; init; }

    /// <summary>
    /// Whether the Chromecast button appears in the video page player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chromecast")]
    public bool? Chromecast { get; init; }

    /// <summary>
    /// Whether closed captions are enabled in the video page player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("closed_captions")]
    public bool? ClosedCaptions { get; init; }

    /// <summary>
    /// A collection of information about the colors in the video page player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("colors")]
    public Colors1? Colors { get; init; }

    /// <summary>
    /// Whether the right-click menu is shown in the video page player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("context_menu")]
    public bool? ContextMenu { get; init; }

    /// <summary>
    /// Whether to display the button for fullscreen mode on the video page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fullscreen")]
    public bool? Fullscreen { get; init; }

    /// <summary>
    /// A collection of information about the logo in the corner of the onsite player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logos")]
    public Logos1? Logos { get; init; }

    /// <summary>
    /// Whether the video is muted by default for viewers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("muted")]
    public bool? Muted { get; init; }

    /// <summary>
    /// Whether picture-in-picture is enabled in the video page player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pip")]
    public bool? Pip { get; init; }

    /// <summary>
    /// A representation of the play button's settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("play_button")]
    public PlayButton1? PlayButton { get; init; }

    /// <summary>
    /// Whether to display the playbar on the video page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("playbar")]
    public bool? Playbar { get; init; }

    /// <summary>
    /// Whether the quality selector appears in the video page player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quality_selector")]
    public bool? QualitySelector { get; init; }

    /// <summary>
    /// Whether to enable users to skip forward in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skipping_forward")]
    public bool? SkippingForward { get; init; }

    /// <summary>
    /// Whether to display speed options in the video page player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speed")]
    public bool? Speed { get; init; }

    /// <summary>
    /// Whether to display the volume control on the video page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("volume")]
    public bool? Volume { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
