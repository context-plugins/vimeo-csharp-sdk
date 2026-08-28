using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.AnyOf;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record EmbedSettings
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

    /// <summary>
    /// Whether automatic picture-in-picture is enabled.
    /// </summary>
    [JsonPropertyName("autopip")]
    public required bool Autopip { get; init; }

    /// <summary>
    /// Whether the video autoplays in the embeddable player.
    /// </summary>
    [JsonPropertyName("autoplay")]
    public required bool Autoplay { get; init; }

    /// <summary>
    /// A collection of the video's badges.
    /// </summary>
    [JsonPropertyName("badges")]
    public required Badges Badges { get; init; }

    /// <summary>
    /// A collection of information about the buttons that appear on the interface of the embeddable player.
    /// </summary>
    [JsonPropertyName("buttons")]
    public required Buttons Buttons { get; init; }

    /// <summary>
    /// A collection of cards associated with the selected video.
    /// </summary>
    [JsonPropertyName("cards")]
    public required IReadOnlyList<Card> Cards { get; init; }

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

    /// <summary>
    /// A collection of information about player colors.
    /// </summary>
    [JsonPropertyName("colors")]
    public required Colors Colors { get; init; }

    /// <summary>
    /// Whether the right-click context menu appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("context_menu")]
    public required bool ContextMenu { get; init; }

    /// <summary>
    /// The email capture form settings associated with the video. _This field is deprecated._
    /// </summary>
    [JsonPropertyName("email_capture_form")]
    public required object EmailCaptureForm { get; init; }

    /// <summary>
    /// A collection of information about the embeddable player's end screen. The API returns an empty array instead of an object when no end screen is configured for the video.
    /// </summary>
    [JsonPropertyName("end_screen")]
    public required EndScreen3 EndScreen { get; init; }

    /// <summary>
    /// Whether the embedded player should display the event schedule.
    /// </summary>
    [JsonPropertyName("event_schedule")]
    public required bool EventSchedule { get; init; }

    /// <summary>
    /// Whether the video has cards.
    /// </summary>
    [JsonPropertyName("has_cards")]
    public required bool HasCards { get; init; }

    /// <summary>
    /// The HTML code for embedding the video on a web page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("html")]
    public string? Html { get; init; }

    /// <summary>
    /// Whether the video is an interactive video.
    /// </summary>
    [JsonPropertyName("interactive")]
    public required bool Interactive { get; init; }

    /// <summary>
    /// A collection of information about the logo in the corner of the embeddable player.
    /// </summary>
    [JsonPropertyName("logos")]
    public required Logos Logos { get; init; }

    /// <summary>
    /// Whether the video starts muted in the embeddable player.
    /// </summary>
    [JsonPropertyName("muted")]
    public required bool Muted { get; init; }

    /// <summary>
    /// The type of the video outro.
    /// <para>
    /// Option descriptions:
    ///  * <c>beginning</c> - The outro is a thumbnail.
    ///  * <c>custom</c> - The outro is custom.
    ///  * <c>email</c> - The outro is an email form.
    ///  * <c>image</c> - The outro is an image.
    ///  * <c>link</c> - The outro is a link.
    ///  * <c>loop</c> - The outro is a loop.
    ///  * <c>nothing</c> - There is no outro.
    ///  * <c>share</c> - The outro is a share button.
    ///  * <c>text</c> - The outro is text.
    ///  * <c>threevideos</c> - The outro is three video suggestions.
    ///  * <c>videos</c> - The outro is video suggestions.
    /// </para>
    /// </summary>
    [JsonPropertyName("outro_type")]
    public required OutroType OutroType { get; init; }

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
    /// Whether the quality selector appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("quality_selector")]
    public required bool QualitySelector { get; init; }

    /// <summary>
    /// The sentiment widget configuration for the video.
    /// </summary>
    [JsonPropertyName("sentiment_widgets")]
    public required IReadOnlyList<SentimentWidget> SentimentWidgets { get; init; }

    /// <summary>
    /// Whether the embedded player displays the schedule timezone.
    /// </summary>
    [JsonPropertyName("show_timezone")]
    public required bool ShowTimezone { get; init; }

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
    /// A collection of information about the embeddable player's title bar.
    /// </summary>
    [JsonPropertyName("title")]
    public required Title Title { get; init; }

    /// <summary>
    /// Whether the transcript controls appear in the embeddable player.
    /// </summary>
    [JsonPropertyName("transcript")]
    public required bool Transcript { get; init; }

    /// <summary>
    /// The URI of the embed preset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }

    /// <summary>
    /// Whether the volume controls appear in the embeddable player.
    /// </summary>
    [JsonPropertyName("volume")]
    public required bool Volume { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
