using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the user's profile.
/// </summary>
public record ViewProfile
{
    /// <summary>
    /// Information regarding the current authenticated user's inability to access the user's profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disabled")]
    public Disabled? Disabled { get; init; }

    /// <summary>
    /// Whether the current authenticated user can access the user's profile with a moderator override.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mod_override")]
    public bool? ModOverride { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI for the current authenticated user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public IReadOnlyList<string>? Options { get; init; }

    /// <summary>
    /// The API URI that resolves to the user's profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }
}
