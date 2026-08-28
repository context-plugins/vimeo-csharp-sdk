using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
