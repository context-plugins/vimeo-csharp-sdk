using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record ProjectItem
{
    /// <summary>
    /// The project item folder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("folder")]
    public Project? Folder { get; init; }

    /// <summary>
    /// The project item event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("live_event")]
    public RecurringEvent? LiveEvent { get; init; }

    /// <summary>
    /// The item's metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata24 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the item was shared.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shared_date")]
    public string? SharedDate { get; init; }

    /// <summary>
    /// The project item showcase.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("showcase")]
    public Album? Showcase { get; init; }

    /// <summary>
    /// The project item type.
    /// <para>
    /// Option descriptions:
    ///  * <c>folder</c> - The project item is a folder.
    ///  * <c>live_event</c> - The project item is an event.
    ///  * <c>showcase</c> - The project item is a showcase.
    ///  * <c>video</c> - The project item is a video.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type21 Type { get; init; }

    /// <summary>
    /// The project item video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("video")]
    public Video? Video { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
