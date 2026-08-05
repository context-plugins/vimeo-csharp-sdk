using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Preorder
{
    /// <summary>
    /// Whether the On Demand page is available for preorder.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the preorder was cancelled.
    /// </summary>
    [JsonPropertyName("cancel_time")]
    public required string CancelTime { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the preorder was released to the public.
    /// </summary>
    [JsonPropertyName("publish_time")]
    public required string PublishTime { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the preorder started.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; init; }
}
