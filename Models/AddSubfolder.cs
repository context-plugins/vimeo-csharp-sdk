using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about adding a subfolder to the current folder.
/// </summary>
public record AddSubfolder
{
    /// <summary>
    /// Whether the folder can contain a subfolder.
    /// </summary>
    [JsonPropertyName("can_add_subfolders")]
    public required bool CanAddSubfolders { get; init; }

    /// <summary>
    /// The subfolder content type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content_type")]
    public string? ContentType { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public IReadOnlyList<string>? Options { get; init; }

    /// <summary>
    /// Properties that can be added to the request body.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("properties")]
    public IReadOnlyList<string>? Properties { get; init; }

    /// <summary>
    /// Whether the user has reached the maximum subfolder depth.
    /// </summary>
    [JsonPropertyName("subfolder_depth_limit_reached")]
    public required bool SubfolderDepthLimitReached { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }
}
