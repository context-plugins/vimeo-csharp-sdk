using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record DirectorTimeline1
{
    /// <summary>
    /// The 360 director timeline pitch. This value must be between <c>−90</c> and <c>90</c>, and it's required only when <b>spatial.director_timeline</b> is defined.
    /// </summary>
    [JsonPropertyName("pitch")]
    public required double Pitch { get; init; }

    /// <summary>
    /// The 360 director timeline roll.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roll")]
    public double? Roll { get; init; }

    /// <summary>
    /// The 360 director timeline time code. This field is required only when <b>spatial.director_timeline</b> is defined.
    /// </summary>
    [JsonPropertyName("time_code")]
    public required double TimeCode { get; init; }

    /// <summary>
    /// The 360 director timeline yaw. This value must be between <c>0</c> and <c>360</c>, and it's required only when <b>spatial.director_timeline</b> is defined.
    /// </summary>
    [JsonPropertyName("yaw")]
    public required double Yaw { get; init; }
}
