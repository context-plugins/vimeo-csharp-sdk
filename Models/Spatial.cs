using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The video's 360 spatial data.
/// </summary>
public record Spatial
{
    /// <summary>
    /// The video's 360 director timeline.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("director_timeline")]
    public IReadOnlyList<DirectorTimeline>? DirectorTimeline { get; init; }

    /// <summary>
    /// The video's 360 field of view value, ranging from a mininum of <c>30</c> to a maximum of <c>90</c>. The default value is <c>50</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("field_of_view")]
    public double? FieldOfView { get; init; }

    /// <summary>
    /// The video's 360 spatial projection.
    /// <para>
    /// Option descriptions:
    ///  * <c>cubical</c> - The spatial projection is cubical.
    ///  * <c>cylindrical</c> - The spatial projection is cylindrical.
    ///  * <c>dome</c> - The spatial projection is dome-shaped.
    ///  * <c>equirectangular</c> - The spatial projection is equirectangular.
    ///  * <c>pyramid</c> - The spatial projection is pyramid-shaped.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("projection")]
    public Projection? Projection { get; init; }

    /// <summary>
    /// The video's 360 stereo format.
    /// <para>
    /// Option descriptions:
    ///  * <c>left-right</c> - The stereo format is left-right.
    ///  * <c>mono</c> - The audio is monaural.
    ///  * <c>top-bottom</c> - The stereo format is top-bottom.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stereo_format")]
    public StereoFormat? StereoFormat { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
