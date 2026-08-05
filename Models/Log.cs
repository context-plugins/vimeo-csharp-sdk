using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Log
{
    /// <summary>
    /// The URL to record a Play logging event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("play")]
    public string? Play { get; init; }
}
