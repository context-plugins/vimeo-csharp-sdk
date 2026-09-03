using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record VideoPageSettings
{
    /// <summary>
    /// Whether to display the button for Vimeo AI on the video page.
    /// </summary>
    [JsonPropertyName("ask_ai")]
    public required bool AskAi { get; init; }

    /// <summary>
    /// Whether to display video categories on the video page.
    /// </summary>
    [JsonPropertyName("categories")]
    public required bool Categories { get; init; }

    /// <summary>
    /// Whether to display the button for chapters on the video page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chapters")]
    public bool? Chapters { get; init; }

    /// <summary>
    /// Whether to display collections on the video page.
    /// </summary>
    [JsonPropertyName("collections")]
    public required bool Collections { get; init; }

    /// <summary>
    /// Whether to display comments on the video page.
    /// </summary>
    [JsonPropertyName("comments")]
    public required bool Comments { get; init; }

    /// <summary>
    /// Whether to display the video's Creative Commons license on the video page.
    /// </summary>
    [JsonPropertyName("creative_commons")]
    public required bool CreativeCommons { get; init; }

    /// <summary>
    /// Whether to display credits for the video on the video page.
    /// </summary>
    [JsonPropertyName("credits")]
    public required bool Credits { get; init; }

    /// <summary>
    /// The contents of the page customization group (background color, title font, and inline logo).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customization")]
    public Customization? Customization { get; init; }

    /// <summary>
    /// Whether to display the date when the video was added on the video page.
    /// </summary>
    [JsonPropertyName("date_added")]
    public required bool DateAdded { get; init; }

    /// <summary>
    /// Whether to display the video's description on the video page.
    /// </summary>
    [JsonPropertyName("description")]
    public required bool Description { get; init; }

    /// <summary>
    /// Whether to display the button for downloads on the video page.
    /// </summary>
    [JsonPropertyName("download")]
    public required bool Download { get; init; }

    /// <summary>
    /// Whether to display the button for likes on the video page.
    /// </summary>
    [JsonPropertyName("like")]
    public required bool Like { get; init; }

    /// <summary>
    /// Whether to display the video owner's user name on the video page.
    /// </summary>
    [JsonPropertyName("owner")]
    public required bool Owner { get; init; }

    /// <summary>
    /// The contents of the player group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("player")]
    public Player? Player { get; init; }

    /// <summary>
    /// Whether to display the video owner's avatar on the video page.
    /// </summary>
    [JsonPropertyName("portrait")]
    public required bool Portrait { get; init; }

    /// <summary>
    /// Whether to display the button for shares on the video page.
    /// </summary>
    [JsonPropertyName("share")]
    public required bool Share { get; init; }

    /// <summary>
    /// Whether to display tags for the video on the video page.
    /// </summary>
    [JsonPropertyName("tags")]
    public required bool Tags { get; init; }

    /// <summary>
    /// Whether to display the video title on the video page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public bool? Title { get; init; }

    /// <summary>
    /// Whether to display the button for transcripts on the video page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transcript")]
    public bool? Transcript { get; init; }

    /// <summary>
    /// Whether to display the video's uploader on the video page.
    /// </summary>
    [JsonPropertyName("uploader")]
    public required bool Uploader { get; init; }

    /// <summary>
    /// The URI of the page preset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }

    /// <summary>
    /// Whether to display the number of views that the video has received on the video page.
    /// </summary>
    [JsonPropertyName("views")]
    public required bool Views { get; init; }

    /// <summary>
    /// Whether to display the button for watching later on the video page.
    /// </summary>
    [JsonPropertyName("watch_later")]
    public required bool WatchLater { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
