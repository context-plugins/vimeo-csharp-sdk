using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record FederatedSearchItems
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
}
