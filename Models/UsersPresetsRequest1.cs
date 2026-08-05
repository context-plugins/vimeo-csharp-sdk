using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record UsersPresetsRequest1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed")]
    public Embed17? Embed { get; init; }

    /// <summary>
    /// The name of the embed preset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// What to do with the outro.
    /// <para>
    /// Option descriptions:
    ///  * <c>nothing</c> - Disable the outro.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("outro")]
    public Outro1? Outro { get; init; }
}
