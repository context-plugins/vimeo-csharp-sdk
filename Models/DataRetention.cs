using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record DataRetention
{
    /// <summary>
    /// Information about the folder's data retention policy. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("policy")]
    public required Policy Policy { get; init; }
}
