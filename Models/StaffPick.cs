using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record StaffPick
{
    /// <summary>
    /// Whether the video is a Vimeo Staff Pick Best of the Month.
    /// </summary>
    [JsonPropertyName("best_of_the_month")]
    public required bool BestOfTheMonth { get; init; }

    /// <summary>
    /// Whether the video is a Vimeo Staff Pick Best of the Year.
    /// </summary>
    [JsonPropertyName("best_of_the_year")]
    public required bool BestOfTheYear { get; init; }

    /// <summary>
    /// Whether the video is a Vimeo Staff Pick.
    /// </summary>
    [JsonPropertyName("normal")]
    public required bool Normal { get; init; }

    /// <summary>
    /// Whether the video is a Vimeo Staff Pick Premiere.
    /// </summary>
    [JsonPropertyName("premiere")]
    public required bool Premiere { get; init; }
}
