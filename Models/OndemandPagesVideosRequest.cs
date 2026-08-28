using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record OndemandPagesVideosRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy")]
    public Buy5? Buy { get; init; }

    /// <summary>
    /// The position of the video in the On Demand collection.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("position")]
    public double? Position { get; init; }

    /// <summary>
    /// The release year of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("release_year")]
    public double? ReleaseYear { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rent")]
    public Rent5? Rent { get; init; }

    /// <summary>
    /// The type of the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>extra</c> - The video type is extra footage.
    ///  * <c>main</c> - The video type is the main video.
    ///  * <c>trailer</c> - The video type is a trailer.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type42 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
