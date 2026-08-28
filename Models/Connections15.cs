using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A collection of information that is connected to this resource.
/// </summary>
public record Connections15
{
    /// <summary>
    /// Information about the event's live video, where applicable.
    /// </summary>
    [JsonPropertyName("live_video")]
    public required LiveVideo? LiveVideo { get; init; }

    /// <summary>
    /// Information about the event's thumbnails.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Pictures3 Pictures { get; init; }

    /// <summary>
    /// Information about the event's pre-live video, where applicable. A pre-live video is either activated or in the process of being activated.
    /// </summary>
    [JsonPropertyName("pre_live_video")]
    public required PreLiveVideo? PreLiveVideo { get; init; }

    /// <summary>
    /// Information about the team member who owns the event.
    /// </summary>
    [JsonPropertyName("team_member")]
    public required TeamMember? TeamMember { get; init; }

    /// <summary>
    /// Information about the videos that belong to the event.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos10 Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
