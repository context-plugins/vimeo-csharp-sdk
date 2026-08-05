using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record LiveEventsComposerScenesRequest
{
    /// <summary>
    /// The type of scene to create. Defaults to <c>live</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scene_type")]
    public string? SceneType { get; init; }
}
