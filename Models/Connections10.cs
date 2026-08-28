using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Connections10
{
    /// <summary>
    /// Information about the comments associated with the On Demand page.
    /// </summary>
    [JsonPropertyName("comments")]
    public required Comments3 Comments { get; init; }

    /// <summary>
    /// Information about the genres associated with the On Demand page.
    /// </summary>
    [JsonPropertyName("genres")]
    public required Genres Genres { get; init; }

    /// <summary>
    /// Information about the likes associated with the On Demand page.
    /// </summary>
    [JsonPropertyName("likes")]
    public required Likes2 Likes { get; init; }

    /// <summary>
    /// Information about the pictures associated with the On Demand page.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Pictures2 Pictures { get; init; }

    /// <summary>
    /// Information about the seasons associated with the On Demand page.
    /// </summary>
    [JsonPropertyName("seasons")]
    public required Seasons Seasons { get; init; }

    /// <summary>
    /// Information about the videos associated with the On Demand page.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos8 Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
