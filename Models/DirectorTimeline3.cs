using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record DirectorTimeline3
{
    /// <summary>
    /// The 360 director timeline pitch. This value must be between −90 and 90, and you must specify it only when <b>spatial.director_timeline</b> is defined.
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
    /// The 360 director timeline time code. This paramater is required only when <b>spatial.director_timeline</b> is defined.
    /// </summary>
    [JsonPropertyName("time_code")]
    public required double TimeCode { get; init; }

    /// <summary>
    /// The 360 director timeline yaw. This value must be between 0 and 360, and you must specify it only when <b>spatial.director_timeline</b> is defined.
    /// </summary>
    [JsonPropertyName("yaw")]
    public required double Yaw { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
