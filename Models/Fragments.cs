using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Fragments
{
    /// <summary>
    /// The time in ISO 8601 format when the fragment was created.
    /// </summary>
    [JsonPropertyName("created_on")]
    public required string CreatedOn { get; init; }

    /// <summary>
    /// Metadata about the fragments.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata18 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the fragment was last updated.
    /// </summary>
    [JsonPropertyName("modified_on")]
    public required string ModifiedOn { get; init; }

    /// <summary>
    /// The time in milliseconds of the fragment's _inpoint_, or the time from the start of the video that marks the beginning of the fragment.
    /// </summary>
    [JsonPropertyName("timecode")]
    public required double Timecode { get; init; }

    /// <summary>
    /// The URI of the video fragment.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
