using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A list of resource URIs related to the video.
/// </summary>
public record Connections4
{
    /// <summary>
    /// Information about the showcases that contain the video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("albums")]
    public Albums1? Albums { get; init; }

    /// <summary>
    /// Information about the video's ancestry, ordered from the direct parent folder to higher-level ancestors.
    /// </summary>
    [JsonPropertyName("ancestor_path")]
    public required IReadOnlyList<AncestorPath> AncestorPath { get; init; }

    /// <summary>
    /// Information about the available showcases, or the showcases to which the video can be added. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available_albums")]
    public AvailableAlbums? AvailableAlbums { get; init; }

    /// <summary>
    /// Information about the channels to which the video can be added. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available_channels")]
    public AvailableChannels? AvailableChannels { get; init; }

    /// <summary>
    /// Information about the comments on the video.
    /// </summary>
    [JsonPropertyName("comments")]
    public required Comments1 Comments { get; init; }

    /// <summary>
    /// Information about the users credited in the video.
    /// </summary>
    [JsonPropertyName("credits")]
    public required Credits? Credits { get; init; }

    /// <summary>
    /// Information about the users who have liked the video.
    /// </summary>
    [JsonPropertyName("likes")]
    public required Likes1 Likes { get; init; }

    /// <summary>
    /// Information about the video's On Demand data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ondemand")]
    public Ondemand? Ondemand { get; init; }

    /// <summary>
    /// Information about the video's thumbnails.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Pictures1 Pictures { get; init; }

    /// <summary>
    /// Information about the user's publish-to-social history for the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publish_to_social")]
    public PublishToSocial? PublishToSocial { get; init; }

    /// <summary>
    /// Information about the recommendations for the video.
    /// </summary>
    [JsonPropertyName("recommendations")]
    public required Recommendations? Recommendations { get; init; }

    /// <summary>
    /// Information about the video's related content.
    /// </summary>
    [JsonPropertyName("related")]
    public required Related? Related { get; init; }

    /// <summary>
    /// Information about the team user who uploaded the video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("resource_creator_team_user")]
    public required ResourceCreatorTeamUser ResourceCreatorTeamUser { get; init; }

    /// <summary>
    /// Information about the video's season.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("season")]
    public Season? Season { get; init; }

    /// <summary>
    /// Information about the video's team permissions list. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("team_permissions")]
    public TeamPermissions? TeamPermissions { get; init; }

    /// <summary>
    /// Information about the video's text tracks.
    /// </summary>
    [JsonPropertyName("texttracks")]
    public required Texttracks Texttracks { get; init; }

    /// <summary>
    /// Information about the video's Vimeo On Demand trailer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trailer")]
    public Trailer? Trailer { get; init; }

    /// <summary>
    /// Information about the user privacy of the video, if the video privacy setting is <c>users</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("users_with_access")]
    public UsersWithAccess? UsersWithAccess { get; init; }

    /// <summary>
    /// Information about the video's versions.
    /// </summary>
    [JsonPropertyName("versions")]
    public required Versions Versions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
