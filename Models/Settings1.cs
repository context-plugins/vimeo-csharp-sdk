using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The contents of the preset group.
/// </summary>
public record Settings1
{
    /// <summary>
    /// Whether AirPlay is enabled in the embeddable player.
    /// </summary>
    [JsonPropertyName("airplay")]
    public required bool Airplay { get; init; }

    /// <summary>
    /// Whether Ask AI is enabled in the embeddable player.
    /// </summary>
    [JsonPropertyName("ask_ai")]
    public required bool AskAi { get; init; }

    /// <summary>
    /// Whether multiple audio tracks can appear in the embeddable player.
    /// </summary>
    [JsonPropertyName("audio_tracks")]
    public required bool AudioTracks { get; init; }

    [JsonPropertyName("buttons")]
    public required Buttons1 Buttons { get; init; }

    /// <summary>
    /// How the embeddable player handles the video owner's information.
    /// <para>
    /// Option descriptions:
    ///  * <c>hide</c> - The owner's information is hidden.
    ///  * <c>show</c> - The owner's information is shown.
    ///  * <c>user</c> - The owner's information can be toggled to <c>show</c> or <c>hide</c> by the user.
    /// </para>
    /// </summary>
    [JsonPropertyName("byline")]
    public required Byline Byline { get; init; }

    /// <summary>
    /// Whether clicking the closed-captions button reveals the caption-language menu in the embeddable player.
    /// </summary>
    [JsonPropertyName("cc_track_menu")]
    public required bool CcTrackMenu { get; init; }

    /// <summary>
    /// Whether chapters are enabled in the embeddable player.
    /// </summary>
    [JsonPropertyName("chapters")]
    public required bool Chapters { get; init; }

    /// <summary>
    /// Whether the Chromecast button appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("chromecast")]
    public required bool Chromecast { get; init; }

    /// <summary>
    /// Whether closed captions are enabled in the embeddable player.
    /// </summary>
    [JsonPropertyName("closed_captions")]
    public required bool ClosedCaptions { get; init; }

    /// <summary>
    /// The second player color, which controls the player accent color. _This field is identical to <b>colors.color_two</b>._
    /// </summary>
    [JsonPropertyName("color")]
    public required string Color { get; init; }

    [JsonPropertyName("colors")]
    public required Colors5 Colors { get; init; }

    /// <summary>
    /// A representation of the end screen settings.
    /// </summary>
    [JsonPropertyName("end_screen")]
    public required EndScreen1 EndScreen { get; init; }

    [JsonPropertyName("outro")]
    public required Outro Outro { get; init; }

    /// <summary>
    /// Whether picture-in-picture is enabled and the button appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("pip")]
    public required bool Pip { get; init; }

    /// <summary>
    /// A representation of the play button's settings.
    /// </summary>
    [JsonPropertyName("play_button")]
    public required PlayButton PlayButton { get; init; }

    /// <summary>
    /// Whether the playbar appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("playbar")]
    public required bool Playbar { get; init; }

    /// <summary>
    /// How the embeddable player handles the video owner's portrait.
    /// <para>
    /// Option descriptions:
    ///  * <c>hide</c> - The owner's portrait is hidden.
    ///  * <c>show</c> - The owner's portrait is shown.
    ///  * <c>user</c> - The owner's portrait can be toggled to <c>show</c> or <c>hide</c> by the user.
    /// </para>
    /// </summary>
    [JsonPropertyName("portrait")]
    public required Portrait1 Portrait { get; init; }

    /// <summary>
    /// Whether to show the quality selector in the embeddable player.
    /// </summary>
    [JsonPropertyName("quality_selector")]
    public required bool QualitySelector { get; init; }

    /// <summary>
    /// Whether users can skip forward in the embeddable player.
    /// </summary>
    [JsonPropertyName("skipping_forward")]
    public required bool SkippingForward { get; init; }

    /// <summary>
    /// Whether the speed controls appear in the embeddable player.
    /// </summary>
    [JsonPropertyName("speed")]
    public required bool Speed { get; init; }

    /// <summary>
    /// How the embeddable player handles the video title.
    /// <para>
    /// Option descriptions:
    ///  * <c>hide</c> - The title is hidden.
    ///  * <c>show</c> - The title is shown.
    ///  * <c>user</c> - The title can be toggled to <c>show</c> or <c>hide</c> by the user.
    /// </para>
    /// </summary>
    [JsonPropertyName("title")]
    public required Title1 Title { get; init; }

    /// <summary>
    /// Whether the transcript controls appear in the embeddable player.
    /// </summary>
    [JsonPropertyName("transcript")]
    public required bool Transcript { get; init; }

    /// <summary>
    /// Whether the volume controls appear in the embeddable player.
    /// </summary>
    [JsonPropertyName("volume")]
    public required bool Volume { get; init; }
}
