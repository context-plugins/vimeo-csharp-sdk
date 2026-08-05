using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Spatial3
{
    /// <summary>
    /// An array representing the 360 director timeline.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("director_timeline")]
    public IReadOnlyList<DirectorTimeline3>? DirectorTimeline { get; init; }

    /// <summary>
    /// The 360 field of view. This value must be between 30 and 90. The default is 50.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field_of_view")]
    public double? FieldOfView { get; init; }

    /// <summary>
    /// The 360 spatial projection.
    /// <para>
    /// Option descriptions:
    ///  * <c>cubical</c> - Use cubical projection.
    ///  * <c>cylindrical</c> - Use cylindrical projection.
    ///  * <c>dome</c> - Use dome projection.
    ///  * <c>equirectangular</c> - Use equirectangular projection.
    ///  * <c>pyramid</c> - Use pyramid projection.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("projection")]
    public Projection1? Projection { get; init; }

    /// <summary>
    /// The 360 spatial stereo format.
    /// <para>
    /// Option descriptions:
    ///  * <c>left-right</c> - Use left-right stereo.
    ///  * <c>mono</c> - Use monaural audio.
    ///  * <c>top-bottom</c> - Use top-bottom stereo.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stereo_format")]
    public StereoFormat1? StereoFormat { get; init; }
}
