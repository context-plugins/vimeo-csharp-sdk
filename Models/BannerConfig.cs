using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record BannerConfig
{
    /// <summary>
    /// Information about showing the banner on the showcase page.
    /// </summary>
    [JsonPropertyName("show_banner")]
    public required ShowBanner ShowBanner { get; init; }

    /// <summary>
    /// Information about showing the showcase description.
    /// </summary>
    [JsonPropertyName("show_banner_description")]
    public required ShowBannerDescription ShowBannerDescription { get; init; }

    /// <summary>
    /// Information about showing the showcase header.
    /// </summary>
    [JsonPropertyName("show_banner_header")]
    public required ShowBannerHeader ShowBannerHeader { get; init; }

    /// <summary>
    /// Information about showing the showcase title.
    /// </summary>
    [JsonPropertyName("show_banner_title")]
    public required ShowBannerTitle ShowBannerTitle { get; init; }

    /// <summary>
    /// Information about showing the showcase owner's avatar.
    /// </summary>
    [JsonPropertyName("show_showcase_owner_avatar")]
    public required ShowShowcaseOwnerAvatar ShowShowcaseOwnerAvatar { get; init; }

    /// <summary>
    /// Information about showing the button to start watching.
    /// </summary>
    [JsonPropertyName("show_start_watching_button")]
    public required ShowStartWatchingButton ShowStartWatchingButton { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
