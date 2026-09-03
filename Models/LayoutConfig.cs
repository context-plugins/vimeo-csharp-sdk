using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record LayoutConfig
{
    /// <summary>
    /// Information about the grid size configuration.
    /// </summary>
    [JsonPropertyName("grid_size")]
    public required GridSize GridSize { get; init; }

    /// <summary>
    /// Information about showing the profile image on each video.
    /// </summary>
    [JsonPropertyName("show_grid_profile_image")]
    public required ShowGridProfileImage ShowGridProfileImage { get; init; }

    /// <summary>
    /// Information about showing the profile name on each video.
    /// </summary>
    [JsonPropertyName("show_grid_profile_name")]
    public required ShowGridProfileName ShowGridProfileName { get; init; }

    /// <summary>
    /// Information about showing the section names.
    /// </summary>
    [JsonPropertyName("show_grid_section_name")]
    public required ShowGridSectionName ShowGridSectionName { get; init; }

    /// <summary>
    /// Information about showing the video count above the video list.
    /// </summary>
    [JsonPropertyName("show_grid_video_count")]
    public required ShowGridVideoCount ShowGridVideoCount { get; init; }

    /// <summary>
    /// Information about showing the video titles below thumbnails.
    /// </summary>
    [JsonPropertyName("show_grid_video_titles")]
    public required ShowGridVideoTitles ShowGridVideoTitles { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
