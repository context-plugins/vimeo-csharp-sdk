using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the archive data.
/// </summary>
public record Archive
{
    /// <summary>
    /// The ID of the archived video.
    /// </summary>
    [JsonPropertyName("clip_id")]
    public required double ClipId { get; init; }

    /// <summary>
    /// The status of the archive data.
    /// </summary>
    [JsonPropertyName("status")]
    public required double? Status { get; init; }
}
