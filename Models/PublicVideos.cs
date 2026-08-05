using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record PublicVideos
{
    /// <summary>
    /// The total number of public videos that the authenticated user has uploaded.
    /// </summary>
    [JsonPropertyName("total")]
    public required double Total { get; init; }
}
