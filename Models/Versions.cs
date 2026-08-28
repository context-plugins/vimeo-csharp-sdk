using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Information about the video's versions.
/// </summary>
public record Versions
{
    /// <summary>
    /// The storyboard ID of the video version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("create_storyboard_id")]
    public string? CreateStoryboardId { get; init; }

    /// <summary>
    /// The URI of the current version of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_uri")]
    public string? CurrentUri { get; init; }

    /// <summary>
    /// Whether the video has interactive capability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_interactive")]
    public bool? HasInteractive { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public IReadOnlyList<string>? Options { get; init; }

    /// <summary>
    /// Whether the video has unified resolution. If the value of this field is <c>false</c>, the video requires transcoding.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origin_variable_frame_resolution")]
    public bool? OriginVariableFrameResolution { get; init; }

    /// <summary>
    /// The resource key string of the current version of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resource_key")]
    public string? ResourceKey { get; init; }

    /// <summary>
    /// The sequence number of the video version.
    /// </summary>
    [JsonPropertyName("sequence_number")]
    public required double? SequenceNumber { get; init; }

    /// <summary>
    /// The total number of versions on this connection.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total")]
    public double? Total { get; init; }

    /// <summary>
    /// The total number of versions on this connection, including deleted versions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("total_including_deleted")]
    public double? TotalIncludingDeleted { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
