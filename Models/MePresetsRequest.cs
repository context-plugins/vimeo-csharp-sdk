using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record MePresetsRequest
{
    /// <summary>
    /// Whether to apply the preset to all of the user's videos.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apply_to_all")]
    public bool? ApplyToAll { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed")]
    public Embed16? Embed { get; init; }

    /// <summary>
    /// The name of the embed preset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
