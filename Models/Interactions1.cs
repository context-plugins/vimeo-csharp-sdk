using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A list of resource URIs related to the channel.
/// </summary>
public record Interactions1
{
    /// <summary>
    /// An action indicating that the authenticated user is the owner of the channel and may therefore add other users as channel moderators. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("add_moderators")]
    public required AddModerators AddModerators { get; init; }

    /// <summary>
    /// When a channel appears in the context of adding or removing a video from it (<c>/videos/{video_id}/available_channels</c>), include information about adding or removing the video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("add_to")]
    public required AddTo? AddTo { get; init; }

    /// <summary>
    /// An action indicating if the authenticated user has followed this channel. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("follow")]
    public required Follow1 Follow { get; init; }

    /// <summary>
    /// An action indicating that the authenticated user is a moderator of the channel and may therefore add or remove videos from the channel. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("moderate_videos")]
    public required ModerateVideos ModerateVideos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
