using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// An action indicating if the authenticated user has followed the category.
/// </summary>
public record Follow
{
    /// <summary>
    /// Whether the authenticated user has followed the category.
    /// </summary>
    [JsonPropertyName("added")]
    public required bool Added { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the user followed the category, or the null value if the user hasn't followed the category.
    /// </summary>
    [JsonPropertyName("added_time")]
    public required string? AddedTime { get; init; }

    /// <summary>
    /// The URI for following or unfollowing the category: PUT to this URI to follow the category, or DELETE to this URI to unfollow the category.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
