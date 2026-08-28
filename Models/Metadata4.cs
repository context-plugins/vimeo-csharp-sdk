using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The video's metadata.
/// </summary>
public record Metadata4
{
    /// <summary>
    /// Information about the video's AI content.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ai_content")]
    public AiContent? AiContent { get; init; }

    /// <summary>
    /// Whether the video can be replaced.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_be_replaced")]
    public bool? CanBeReplaced { get; init; }

    /// <summary>
    /// A list of resource URIs related to the video.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections4 Connections { get; init; }

    /// <summary>
    /// The video's Vimeo Create ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("edit_session_vsid")]
    public double? EditSessionVsid { get; init; }

    /// <summary>
    /// Whether the video has chapter suggestions.
    /// </summary>
    [JsonPropertyName("has_chapter_suggestions")]
    public required bool HasChapterSuggestions { get; init; }

    /// <summary>
    /// Whether the video has the email capture feature.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_email_capture")]
    public bool? HasEmailCapture { get; init; }

    /// <summary>
    /// The video contains an interactive quiz.
    /// </summary>
    [JsonPropertyName("has_interactive_quiz")]
    public required bool? HasInteractiveQuiz { get; init; }

    /// <summary>
    /// Whether the video has mandatory email capture feature.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_mandatory_email_capture")]
    public bool? HasMandatoryEmailCapture { get; init; }

    /// <summary>
    /// A list of resource URIs related to the video.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required Interactions3 Interactions { get; init; }

    /// <summary>
    /// Whether the video is a screen recording.
    /// </summary>
    [JsonPropertyName("is_screen_record")]
    public required bool IsScreenRecord { get; init; }

    /// <summary>
    /// Whether the video is a Vimeo Create video.
    /// </summary>
    [JsonPropertyName("is_vimeo_create")]
    public required bool IsVimeoCreate { get; init; }

    /// <summary>
    /// Whether the video is a Zoom upload.
    /// </summary>
    [JsonPropertyName("is_zoom_upload")]
    public required bool IsZoomUpload { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
