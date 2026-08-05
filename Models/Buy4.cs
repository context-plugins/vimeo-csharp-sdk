using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Buy4
{
    /// <summary>
    /// Whether episodes can be purchased.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// Whether people who buy episodes can download them. To use this parameter, <b>type</b> must be <c>series</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("download")]
    public bool? Download { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public Price3? Price { get; init; }
}
