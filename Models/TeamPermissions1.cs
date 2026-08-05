using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the folder's team permissions list. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record TeamPermissions1
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }
}
