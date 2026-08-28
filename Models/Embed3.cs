using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// The event's embed data.
/// </summary>
public record Embed3
{
    /// <summary>
    /// Whether AirPlay is enabled in the embeddable player.
    /// </summary>
    [JsonPropertyName("airplay")]
    public required bool Airplay { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should autoplay the RLE content.
    /// </summary>
    [JsonPropertyName("autoplay")]
    public required bool Autoplay { get; init; }

    /// <summary>
    /// The list of user-uploaded logos for configuration of the embed player.
    /// </summary>
    [JsonPropertyName("available_player_logos")]
    public required IReadOnlyList<string> AvailablePlayerLogos { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should display the author's name.
    /// </summary>
    [JsonPropertyName("byline")]
    public required bool Byline { get; init; }

    /// <summary>
    /// The chat's iFrame source URL.
    /// </summary>
    [JsonPropertyName("chat_embed_source")]
    public required string? ChatEmbedSource { get; init; }

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
    /// The embed code for RLE chat.
    /// </summary>
    [JsonPropertyName("embed_chat")]
    public required string? EmbedChat { get; init; }

    /// <summary>
    /// The height, width, and source URL properties used to generate the fixed HTML embed code.
    /// </summary>
    [JsonPropertyName("embed_properties")]
    public required EmbedProperties? EmbedProperties { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should display the event schedule.
    /// </summary>
    [JsonPropertyName("event_schedule")]
    public required bool EventSchedule { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should include the fullscreen controls.
    /// </summary>
    [JsonPropertyName("fullscreen_button")]
    public required bool FullscreenButton { get; init; }

    /// <summary>
    /// Whether the Live label should be visible over the player.
    /// </summary>
    [JsonPropertyName("hide_live_label")]
    public required bool HideLiveLabel { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should hide the viewer counter.
    /// </summary>
    [JsonPropertyName("hide_viewer_count")]
    public required bool HideViewerCount { get; init; }

    /// <summary>
    /// The fixed HTML code to embed the event's playlist on a website.
    /// </summary>
    [JsonPropertyName("html")]
    public required string? Html { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should include the button for likes.
    /// </summary>
    [JsonPropertyName("like_button")]
    public required bool LikeButton { get; init; }

    /// <summary>
    /// A collection of information about the logo in the corner of the embeddable player.
    /// </summary>
    [JsonPropertyName("logos")]
    public required Logos2 Logos { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should loop back to the first video once content is exhausted.
    /// </summary>
    [JsonPropertyName("loop")]
    public required bool Loop { get; init; }

    /// <summary>
    /// Whether picture-in-picture is enabled and the button appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("pip")]
    public required bool Pip { get; init; }

    /// <summary>
    /// The position of the player's play button.
    /// <para>
    /// Option descriptions:
    ///  * <c>0</c> - The play button has the default position.
    ///  * <c>1</c> - The play button appears at the bottom of the interface.
    ///  * <c>2</c> - The play button appears in the center of the interface.
    /// </para>
    /// </summary>
    [JsonPropertyName("play_button_position")]
    public required PlayButtonPosition PlayButtonPosition { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should include the playbar.
    /// </summary>
    [JsonPropertyName("playbar")]
    public required bool Playbar { get; init; }

    /// <summary>
    /// Whether the playlist component appears in the embeddable player for this RLE.
    /// </summary>
    [JsonPropertyName("playlist")]
    public required bool Playlist { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should display the author's portrait.
    /// </summary>
    [JsonPropertyName("portrait")]
    public required bool Portrait { get; init; }

    /// <summary>
    /// The responsive HTML code to embed the event's playlist on a website.
    /// </summary>
    [JsonPropertyName("responsive_html")]
    public required string? ResponsiveHtml { get; init; }

    /// <summary>
    /// Whether the schedule component appears in the embeddable player for this RLE.
    /// </summary>
    [JsonPropertyName("schedule")]
    public required bool Schedule { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should display the latest video placeholder.
    /// </summary>
    [JsonPropertyName("show_latest_archived_clip")]
    public required bool ShowLatestArchivedClip { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should display the schedule timezone.
    /// </summary>
    [JsonPropertyName("show_timezone")]
    public required bool ShowTimezone { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should display the video title.
    /// </summary>
    [JsonPropertyName("title")]
    public required bool Title { get; init; }

    /// <summary>
    /// Whether transcripts are enabled in the embeddable player.
    /// </summary>
    [JsonPropertyName("transcript")]
    public required bool Transcript { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should use a custom color or the default Vimeo blue.
    /// </summary>
    [JsonPropertyName("use_color")]
    public required string UseColor { get; init; }

    /// <summary>
    /// Whether the embedded RLE player should include the volume controls.
    /// </summary>
    [JsonPropertyName("volume")]
    public required bool Volume { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
