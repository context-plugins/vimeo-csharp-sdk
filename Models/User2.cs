using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about the user who posted the reply.
/// </summary>
public record User2
{
    /// <summary>
    /// The user's badge type, if applicable.
    /// </summary>
    [JsonPropertyName("badge")]
    public required string? Badge { get; init; }

    /// <summary>
    /// Whether the user has had a staff-picked video.
    /// </summary>
    [JsonPropertyName("is_staff_picked")]
    public required bool IsStaffPicked { get; init; }

    /// <summary>
    /// The absolute URL of the authenticated users's profile page.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The display name of the user who posted the reply.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Information about the user's portraits.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture Pictures { get; init; }

    /// <summary>
    /// The unique identifier to access the user resource.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
