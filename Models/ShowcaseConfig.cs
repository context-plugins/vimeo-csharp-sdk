using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record ShowcaseConfig
{
    /// <summary>
    /// An object containing the showcase's banner display settings.
    /// </summary>
    [JsonPropertyName("banner")]
    public required BannerConfig Banner { get; init; }

    /// <summary>
    /// An object containing the showcase's layout display settings.
    /// </summary>
    [JsonPropertyName("layout")]
    public required LayoutConfig Layout { get; init; }

    /// <summary>
    /// An object containing the showcase's navigation display settings.
    /// </summary>
    [JsonPropertyName("navigation")]
    public required NavigationConfig Navigation { get; init; }

    /// <summary>
    /// An object containing the showcase's playback display settings.
    /// </summary>
    [JsonPropertyName("playback")]
    public required PlaybackConfig Playback { get; init; }

    /// <summary>
    /// Information about showing the account name on the showcase page.
    /// </summary>
    [JsonPropertyName("show_account_name")]
    public required ShowAccountName ShowAccountName { get; init; }

    /// <summary>
    /// Information about showing the avatar on the showcase page.
    /// </summary>
    [JsonPropertyName("show_avatar")]
    public required ShowAvatar ShowAvatar { get; init; }

    /// <summary>
    /// Information about showing the description on the showcase page.
    /// </summary>
    [JsonPropertyName("show_video_description")]
    public required ShowVideoDescription ShowVideoDescription { get; init; }

    /// <summary>
    /// Information about showing video details on the showcase page.
    /// </summary>
    [JsonPropertyName("show_video_details")]
    public required ShowVideoDetails ShowVideoDetails { get; init; }

    /// <summary>
    /// Information about showing video player cards on the showcase page.
    /// </summary>
    [JsonPropertyName("show_video_player_cards")]
    public required ShowVideoPlayerCards ShowVideoPlayerCards { get; init; }

    /// <summary>
    /// Information about showing the title on the showcase page.
    /// </summary>
    [JsonPropertyName("show_video_title")]
    public required ShowVideoTitle ShowVideoTitle { get; init; }

    /// <summary>
    /// Information about the alignment of the call-to-action text on the showcase page.
    /// </summary>
    [JsonPropertyName("text_cta_alignment")]
    public required TextCtaAlignment TextCtaAlignment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
