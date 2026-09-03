using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record PlaybackConfig
{
    /// <summary>
    /// Information about enabling the Ask AI functionality during playback.
    /// </summary>
    [JsonPropertyName("enable_ask_ai")]
    public required EnableAskAi EnableAskAi { get; init; }

    /// <summary>
    /// Information about enabling the comments functionality during playback.
    /// </summary>
    [JsonPropertyName("enable_comments")]
    public required EnableComments EnableComments { get; init; }

    /// <summary>
    /// Information about enabling the download functionality during playback.
    /// </summary>
    [JsonPropertyName("enable_download")]
    public required EnableDownload EnableDownload { get; init; }

    /// <summary>
    /// Information about enabling the like functionality during playback.
    /// </summary>
    [JsonPropertyName("enable_like")]
    public required EnableLike EnableLike { get; init; }

    /// <summary>
    /// Information about enabling the share functionality during playback.
    /// </summary>
    [JsonPropertyName("enable_share")]
    public required EnableShare EnableShare { get; init; }

    /// <summary>
    /// Information about the grid size configuration for playback view.
    /// </summary>
    [JsonPropertyName("playback_grid_size")]
    public required PlaybackGridSize PlaybackGridSize { get; init; }

    /// <summary>
    /// Information about showing the date when the video was added during playback.
    /// </summary>
    [JsonPropertyName("show_playback_added_date")]
    public required ShowPlaybackAddedDate ShowPlaybackAddedDate { get; init; }

    /// <summary>
    /// Information about showing the profile image in grid view.
    /// </summary>
    [JsonPropertyName("show_playback_grid_profile_image")]
    public required ShowPlaybackGridProfileImage ShowPlaybackGridProfileImage { get; init; }

    /// <summary>
    /// Information about showing the profile name in grid view.
    /// </summary>
    [JsonPropertyName("show_playback_grid_profile_name")]
    public required ShowPlaybackGridProfileName ShowPlaybackGridProfileName { get; init; }

    /// <summary>
    /// Information about showing the video card in grid view.
    /// </summary>
    [JsonPropertyName("show_playback_grid_video_card")]
    public required ShowPlaybackGridVideoCard ShowPlaybackGridVideoCard { get; init; }

    /// <summary>
    /// Information about showing the video title in grid view.
    /// </summary>
    [JsonPropertyName("show_playback_grid_video_title")]
    public required ShowPlaybackGridVideoTitle ShowPlaybackGridVideoTitle { get; init; }

    /// <summary>
    /// Information about showing the profile image during playback.
    /// </summary>
    [JsonPropertyName("show_playback_profile_image")]
    public required ShowPlaybackProfileImage ShowPlaybackProfileImage { get; init; }

    /// <summary>
    /// Information about showing the profile name during playback.
    /// </summary>
    [JsonPropertyName("show_playback_profile_name")]
    public required ShowPlaybackProfileName ShowPlaybackProfileName { get; init; }

    /// <summary>
    /// Information about showing the date when the video was uploaded during playback.
    /// </summary>
    [JsonPropertyName("show_playback_uploaded_date")]
    public required ShowPlaybackUploadedDate ShowPlaybackUploadedDate { get; init; }

    /// <summary>
    /// Information about showing the video count during playback.
    /// </summary>
    [JsonPropertyName("show_playback_video_count")]
    public required ShowPlaybackVideoCount ShowPlaybackVideoCount { get; init; }

    /// <summary>
    /// Information about showing the video description during playback.
    /// </summary>
    [JsonPropertyName("show_playback_video_description")]
    public required ShowPlaybackVideoDescription ShowPlaybackVideoDescription { get; init; }

    /// <summary>
    /// Information about showing the video title during playback.
    /// </summary>
    [JsonPropertyName("show_playback_video_title")]
    public required ShowPlaybackVideoTitle ShowPlaybackVideoTitle { get; init; }

    /// <summary>
    /// Information about showing the view count during playback.
    /// </summary>
    [JsonPropertyName("show_playback_views")]
    public required ShowPlaybackViews ShowPlaybackViews { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
