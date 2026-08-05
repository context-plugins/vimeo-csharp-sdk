using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Album
{
    /// <summary>
    /// Whether the showcase permits continuous play.
    /// </summary>
    [JsonPropertyName("allow_continuous_play")]
    public required bool AllowContinuousPlay { get; init; }

    /// <summary>
    /// Whether the showcase permits downloads.
    /// </summary>
    [JsonPropertyName("allow_downloads")]
    public required bool AllowDownloads { get; init; }

    /// <summary>
    /// Whether the showcase permits sharing.
    /// </summary>
    [JsonPropertyName("allow_share")]
    public required bool AllowShare { get; init; }

    /// <summary>
    /// An array of privacy settings supported for this showcase and the requesting user.
    /// </summary>
    [JsonPropertyName("allowed_privacies")]
    public required IReadOnlyList<string> AllowedPrivacies { get; init; }

    /// <summary>
    /// Whether to start playback of the next video in the showcase's embedded playlist immediately after the previous video finishes.
    /// </summary>
    [JsonPropertyName("autoplay")]
    public required bool Autoplay { get; init; }

    /// <summary>
    /// The hexadecimal color code for the color of the player buttons and showcase controls.
    /// </summary>
    [JsonPropertyName("brand_color")]
    public required string? BrandColor { get; init; }

    /// <summary>
    /// The showcase's configuration settings.
    /// </summary>
    [JsonPropertyName("config")]
    public required ShowcaseConfig Config { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the showcase was created.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// The custom logo of the showcase.
    /// </summary>
    [JsonPropertyName("custom_logo")]
    public required Picture? CustomLogo { get; init; }

    /// <summary>
    /// The custom thumbnail image of the showcase.
    /// </summary>
    [JsonPropertyName("custom_thumbnail")]
    public required Picture CustomThumbnail { get; init; }

    /// <summary>
    /// A brief description of the showcase's content.
    /// </summary>
    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    /// <summary>
    /// The custom domain of the showcase.
    /// </summary>
    [JsonPropertyName("domain")]
    public required string? Domain { get; init; }

    /// <summary>
    /// The state of the SSL certificate that is associated with the showcase's domain.
    /// <para>
    /// Option descriptions:
    ///  * <c>0</c> - The new certificate has yet to be processed.
    ///  * <c>1</c> - The new certificate is being processed in the queue.
    ///  * <c>2</c> - The certificate is being processed for renewal in the queue.
    ///  * <c>3</c> - The new certificate has failed to be issued in the queue.
    ///  * <c>4</c> - The certificate has failed to be renewed in the queue.
    ///  * <c>5</c> - The certificate has been successfully issued.
    ///  * <c>6</c> - The certificate has been successfully renewed.
    ///  * <c>7</c> - The certificate has failed in the polling flow.
    ///  * <c>8</c> - The certificate has failed to be renewed in the polling flow.
    ///  * <c>null</c> - There is no associated HTTPS domain with this showcase.
    /// </para>
    /// </summary>
    [JsonPropertyName("domain_certificate_state")]
    public required DomainCertificateState DomainCertificateState { get; init; }

    /// <summary>
    /// The total duration in seconds of all the videos in the showcase.
    /// </summary>
    [JsonPropertyName("duration")]
    public required double Duration { get; init; }

    /// <summary>
    /// Embed data for the showcase.
    /// </summary>
    [JsonPropertyName("embed")]
    public required Embed2 Embed { get; init; }

    /// <summary>
    /// Whether to show the showcase's custom brand color in the player of the showcase's embedded playlist.
    /// </summary>
    [JsonPropertyName("embed_brand_color")]
    public required bool? EmbedBrandColor { get; init; }

    /// <summary>
    /// Whether to show the showcase's custom logo in the player of the showcase's embedded playlist.
    /// </summary>
    [JsonPropertyName("embed_custom_logo")]
    public required bool? EmbedCustomLogo { get; init; }

    /// <summary>
    /// Whether the showcase has a thumbnail.
    /// </summary>
    [JsonPropertyName("has_chosen_thumbnail")]
    public required bool HasChosenThumbnail { get; init; }

    /// <summary>
    /// Whether the showcase has featured content.
    /// </summary>
    [JsonPropertyName("has_featured_content")]
    public required bool HasFeaturedContent { get; init; }

    /// <summary>
    /// Whether the showcase should be hidden from Vimeo when unlisted.
    /// </summary>
    [JsonPropertyName("hide_from_vimeo")]
    public required bool HideFromVimeo { get; init; }

    /// <summary>
    /// Whether to hide Vimeo navigation when displaying the showcase.
    /// </summary>
    [JsonPropertyName("hide_nav")]
    public required bool HideNav { get; init; }

    /// <summary>
    /// Whether to include the upcoming event in the showcase.
    /// </summary>
    [JsonPropertyName("hide_upcoming")]
    public required bool HideUpcoming { get; init; }

    /// <summary>
    /// Whether to hide the Vimeo logo in the player of the showcase's embedded playlist.
    /// </summary>
    [JsonPropertyName("hide_vimeo_logo")]
    public required bool? HideVimeoLogo { get; init; }

    /// <summary>
    /// The type of layout for presenting the showcase.
    /// <para>
    /// Option descriptions:
    ///  * <c>grid</c> - The showcase videos appear in a grid.
    ///  * <c>player</c> - The showcase videos appear in the player.
    /// </para>
    /// </summary>
    [JsonPropertyName("layout")]
    public required Layout Layout { get; init; }

    /// <summary>
    /// The URL of the showcase.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// Whether automatic playback restarts at the top of the showcase's embedded playlist after reaching the end of the last video in the playlist.
    /// </summary>
    [JsonPropertyName("loop")]
    public required bool Loop { get; init; }

    /// <summary>
    /// Metadata about the showcase.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata11 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the showcase was last modified.
    /// </summary>
    [JsonPropertyName("modified_time")]
    public required string ModifiedTime { get; init; }

    /// <summary>
    /// The display name of the showcase.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The active image of the showcase.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture Pictures { get; init; }

    /// <summary>
    /// The privacy settings of the showcase.
    /// </summary>
    [JsonPropertyName("privacy")]
    public required Privacy5 Privacy { get; init; }

    /// <summary>
    /// The resource key of the showcase.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// Whether showcase videos use the review mode URL.
    /// </summary>
    [JsonPropertyName("review_mode")]
    public required bool ReviewMode { get; init; }

    /// <summary>
    /// Whether search engines can index the showcase.
    /// </summary>
    [JsonPropertyName("seo_allow_indexed")]
    public required bool SeoAllowIndexed { get; init; }

    /// <summary>
    /// The SEO description of the showcase.
    /// </summary>
    [JsonPropertyName("seo_description")]
    public required string? SeoDescription { get; init; }

    /// <summary>
    /// The SEO keywords of the showcase.
    /// </summary>
    [JsonPropertyName("seo_keywords")]
    public required IReadOnlyList<string> SeoKeywords { get; init; }

    /// <summary>
    /// The SEO title of the showcase.
    /// </summary>
    [JsonPropertyName("seo_title")]
    public required string? SeoTitle { get; init; }

    /// <summary>
    /// The URL for sharing the showcase.
    /// </summary>
    [JsonPropertyName("share_link")]
    public required string ShareLink { get; init; }

    /// <summary>
    /// The sort order of the showcase.
    /// <para>
    /// Option descriptions:
    ///  * <c>added_first</c> - Sort the showcase videos in order of those most recently added.
    ///  * <c>added_last</c> - Sort the showcase videos in order of those least recently added.
    ///  * <c>alphabetical</c> - Sort the showcase videos alphabetically.
    ///  * <c>arranged</c> - Sort the showcase videos according to their custom arrangement.
    ///  * <c>comments</c> - Sort the showcase videos by number of comments.
    ///  * <c>likes</c> - Sort the showcase videos by number of likes.
    ///  * <c>newest</c> - Sort the showcase videos in order of creation date with the newest first.
    ///  * <c>oldest</c> - Sort the showcase videos in order of creation date with the oldest first.
    ///  * <c>plays</c> - Sort the showcase videos by number of plays.
    /// </para>
    /// </summary>
    [JsonPropertyName("sort")]
    public required Sort Sort { get; init; }

    /// <summary>
    /// The color theme of the showcase.
    /// <para>
    /// Option descriptions:
    ///  * <c>dark</c> - The showcase uses the dark theme.
    ///  * <c>standard</c> - The showcase uses the standard theme.
    /// </para>
    /// </summary>
    [JsonPropertyName("theme")]
    public required Theme Theme { get; init; }

    /// <summary>
    /// The showcase's thumbnail type. The value of this field can be <c>0</c> when no thumbnail is chosen, <c>1</c> when a video or event's thumbnail is chosen, <c>2</c> when a specific frame from a video is chosen, and <c>3</c> when a custom image is chosen.
    /// </summary>
    [JsonPropertyName("thumbnail_type")]
    public required double ThumbnailType { get; init; }

    /// <summary>
    /// The total number of videos in the showcase.
    /// </summary>
    [JsonPropertyName("total_clips")]
    public required double TotalClips { get; init; }

    /// <summary>
    /// The unlisted hash of the showcase. Omit this hash from the showcase URL to prevent access to the showcase on Vimeo.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unlisted_hash")]
    public string? UnlistedHash { get; init; }

    /// <summary>
    /// The URI of the showcase.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The custom Vimeo URL of the showcase.
    /// </summary>
    [JsonPropertyName("url")]
    public required string? Url { get; init; }

    /// <summary>
    /// Whether the showcase uses a custom domain.
    /// </summary>
    [JsonPropertyName("use_custom_domain")]
    public required bool UseCustomDomain { get; init; }

    /// <summary>
    /// The owner of the showcase.
    /// </summary>
    [JsonPropertyName("user")]
    public required User User { get; init; }

    /// <summary>
    /// Whether to use the showcase's brand color in the web layout.
    /// </summary>
    [JsonPropertyName("web_brand_color")]
    public required bool WebBrandColor { get; init; }

    /// <summary>
    /// Whether to use the showcase's custom logo in the web layout.
    /// </summary>
    [JsonPropertyName("web_custom_logo")]
    public required bool WebCustomLogo { get; init; }
}
