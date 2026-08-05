using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Information about the event's live video, where applicable.
/// </summary>
public record LiveVideo
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The status of the live video's RTMP link.
    /// <para>
    /// Option descriptions:
    ///  * <c>streaming</c> - The stream is open and receiving content.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status11 Status { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}
