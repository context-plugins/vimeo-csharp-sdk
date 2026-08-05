using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The request filters to use for child text tracks. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record Filters
{
    /// <summary>
    /// A filter that represents the ID of the parent text track. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parent_id")]
    public double? ParentId { get; init; }
}
