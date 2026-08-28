using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Spatial1
{
    /// <summary>
    /// An array representing the 360 director timeline.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("director_timeline")]
    public IReadOnlyList<DirectorTimeline1>? DirectorTimeline { get; init; }

    /// <summary>
    /// The 360 field of view. This value must be between <c>30</c> and <c>90</c>; the default value is <c>50</c>.
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
