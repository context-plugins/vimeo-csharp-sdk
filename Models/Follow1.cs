using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// An action indicating if the authenticated user has followed this channel. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record Follow1
{
    /// <summary>
    /// Whether the authenticated user has followed this channel. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("added")]
    public required bool Added { get; init; }

    /// <summary>
    /// The time in ISO 8601 format that the user followed this channel, or the null value if the user hasn't followed the channel. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("added_time")]
    public required string? AddedTime { get; init; }

    /// <summary>
    /// The authenticated user's role type. This data requires a bearer token with the <c>private</c> scope.
    /// <para>
    /// Option descriptions:
    ///  * <c>moderator</c> - The authenticated user is a moderator.
    ///  * <c>subscriber</c> - The authenticated user is a subscriber.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type1? Type { get; init; }

    /// <summary>
    /// The URI for following or unfollowing this channel. PUT to this URI to follow the channel, or DELETE to this URI to unfollow the channel. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
