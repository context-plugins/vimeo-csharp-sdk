using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the video's team permissions list. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record TeamPermissions
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public IReadOnlyList<string>? Options { get; init; }
}
