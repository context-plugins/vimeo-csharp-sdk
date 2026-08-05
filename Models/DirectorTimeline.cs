using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record DirectorTimeline
{
    /// <summary>
    /// The timeline pitch value, ranging from a minimum of <c>-90</c> to a maximum of <c>90</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pitch")]
    public double? Pitch { get; init; }

    /// <summary>
    /// The timeline roll value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roll")]
    public double? Roll { get; init; }

    /// <summary>
    /// The timeline time code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time_code")]
    public double? TimeCode { get; init; }

    /// <summary>
    /// The timeline yaw value, ranging from a minimum of <c>0</c> to a maximum of <c>360</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("yaw")]
    public double? Yaw { get; init; }
}
