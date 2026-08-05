using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information regarding the current authenticated user's inability to access the user's profile.
/// </summary>
public record Disabled
{
    /// <summary>
    /// The reasons the current authenticated user can't access the user's profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reasons")]
    public IReadOnlyList<string>? Reasons { get; init; }
}
