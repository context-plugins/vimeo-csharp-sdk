using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// An action indicating that someone has joined the group. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record Join
{
    /// <summary>
    /// Whether the user has followed the group. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("added")]
    public required bool Added { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the user joined the group. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("added_time")]
    public required string? AddedTime { get; init; }

    /// <summary>
    /// The user's title. If this field isn't applicable, it takes the null value. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("title")]
    public required string? Title { get; init; }

    /// <summary>
    /// The user's role type. This data requires a bearer token with the <c>private</c> scope.
    /// <para>
    /// Option descriptions:
    ///  * <c>member</c> - The user is a member.
    ///  * <c>moderator</c> - The user is a moderator.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type8? Type { get; init; }

    /// <summary>
    /// The URI for following the group. PUT to this URI to follow the group, or DELETE to this URI to unfollow the group. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
