using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// Information about the event's pre-live video, where applicable. A pre-live video is either activated or in the process of being activated.
/// </summary>
public record PreLiveVideo
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The status of the pre-live video's RTMP link.
    /// <para>
    /// Option descriptions:
    ///  * <c>pending</c> - Vimeo is working on setting up the connection.
    ///  * <c>ready</c> - Resources have been provisioned for the event.
    ///  * <c>streaming</c> - Live video is currently streaming to the RTMP link.
    ///  * <c>unavailable</c> - The connection is ready, but streaming to the RTMP link has not yet begun.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status12 Status { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
