using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The associated live stream object. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record Live1
{
    /// <summary>
    /// The time in ISO 8601 format when the live stream ended. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("stream_end_time")]
    public required string? StreamEndTime { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the live stream started. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("stream_start_time")]
    public required string? StreamStartTime { get; init; }
}
