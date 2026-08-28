using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A collection of information that is connected to this resource.
/// </summary>
public record Connections1
{
    /// <summary>
    /// Information provided to channel moderators about which users they have specifically permitted to access this private channel. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("privacy_users")]
    public required PrivacyUsers PrivacyUsers { get; init; }

    /// <summary>
    /// Information about the requested video.
    /// </summary>
    [JsonPropertyName("requested_clip")]
    public required RequestedClip RequestedClip { get; init; }

    /// <summary>
    /// Information about the users following or moderating this channel.
    /// </summary>
    [JsonPropertyName("users")]
    public required Users1 Users { get; init; }

    /// <summary>
    /// Information about the videos that belong to this channel.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos1 Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
