using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record ReviewLink
{
    /// <summary>
    /// Whether to allow comments in the review.
    /// </summary>
    [JsonPropertyName("allow_comments")]
    public required bool AllowComments { get; init; }

    /// <summary>
    /// Whether downloads are permitted in the review.
    /// </summary>
    [JsonPropertyName("allow_downloads")]
    public required bool AllowDownloads { get; init; }

    /// <summary>
    /// Whether a status change is permitted in the review.
    /// </summary>
    [JsonPropertyName("allow_status_change")]
    public required bool AllowStatusChange { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the review was created.
    /// </summary>
    [JsonPropertyName("created_on")]
    public required string CreatedOn { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the review expires.
    /// </summary>
    [JsonPropertyName("expires_on")]
    public required string ExpiresOn { get; init; }

    /// <summary>
    /// Whether to hide end cards (other videos) after playback.
    /// </summary>
    [JsonPropertyName("hide_end_cards")]
    public required bool HideEndCards { get; init; }

    /// <summary>
    /// Whether the review link is in dark mode.
    /// </summary>
    [JsonPropertyName("is_dark")]
    public required bool IsDark { get; init; }

    /// <summary>
    /// Whether the review link is enabled.
    /// </summary>
    [JsonPropertyName("is_enabled")]
    public required bool IsEnabled { get; init; }

    /// <summary>
    /// The link to the team logo from the brandkit.
    /// </summary>
    [JsonPropertyName("logo_url")]
    public required string LogoUrl { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the review was last modified.
    /// </summary>
    [JsonPropertyName("modified_on")]
    public required string ModifiedOn { get; init; }

    /// <summary>
    /// The name of the link.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The password for the review link.
    /// </summary>
    [JsonPropertyName("password")]
    public required string? Password { get; init; }

    /// <summary>
    /// Whether showing all versions is permitted in the review.
    /// </summary>
    [JsonPropertyName("show_all_versions")]
    public required bool ShowAllVersions { get; init; }

    /// <summary>
    /// Whether to display the user's logo in the review.
    /// </summary>
    [JsonPropertyName("show_my_logo")]
    public required bool ShowMyLogo { get; init; }

    /// <summary>
    /// Whether to show resolved comments in the review.
    /// </summary>
    [JsonPropertyName("show_resolved_comments")]
    public required bool ShowResolvedComments { get; init; }

    /// <summary>
    /// The canonical relative URI of the review link.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The relative URL of the review link.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
