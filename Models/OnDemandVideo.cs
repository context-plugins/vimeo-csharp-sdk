using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record OnDemandVideo
{
    /// <summary>
    /// Information about purchasing the video.
    /// </summary>
    [JsonPropertyName("buy")]
    public required Buy2? Buy { get; init; }

    /// <summary>
    /// The description of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The duration of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("duration")]
    public string? Duration { get; init; }

    /// <summary>
    /// The episode number of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("episode")]
    public double? Episode { get; init; }

    /// <summary>
    /// An object containing information about how the authenticated user can interact with the video's On Demand page.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required Interactions13 Interactions { get; init; }

    /// <summary>
    /// The link to the video on Vimeo.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// Metadata information about the video.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata21 Metadata { get; init; }

    /// <summary>
    /// The title of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("options")]
    public IReadOnlyList<string>? Options { get; init; }

    /// <summary>
    /// The active picture of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pictures")]
    public Picture? Pictures { get; init; }

    /// <summary>
    /// The authenticated user's most recent play position in the video, in seconds.
    /// </summary>
    [JsonPropertyName("play_progress")]
    public required double PlayProgress { get; init; }

    /// <summary>
    /// The position of the video relative to the other videos on the On Demand page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("position")]
    public double? Position { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video was created or published.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("release_date")]
    public string? ReleaseDate { get; init; }

    /// <summary>
    /// The year that the video was released.
    /// </summary>
    [JsonPropertyName("release_year")]
    public required double? ReleaseYear { get; init; }

    /// <summary>
    /// Information about renting the video.
    /// </summary>
    [JsonPropertyName("rent")]
    public required Rent2? Rent { get; init; }

    /// <summary>
    /// The type of video.
    /// <para>
    /// Option descriptions:
    ///  * <c>extra</c> - The video is an extra feature.
    ///  * <c>main</c> - The video is a main feature.
    ///  * <c>trailer</c> - The video is a trailer.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type19 Type { get; init; }

    /// <summary>
    /// The video container's relative URI.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The owner of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public User? User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
