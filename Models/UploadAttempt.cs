using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UploadAttempt
{
    /// <summary>
    /// The video to upload.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clip")]
    public Video? Clip { get; init; }

    /// <summary>
    /// The HTML upload form.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("form")]
    public string? Form { get; init; }

    /// <summary>
    /// The ticket identifier string for the upload.
    /// </summary>
    [JsonPropertyName("ticket_id")]
    public required string TicketId { get; init; }

    /// <summary>
    /// The upload URL.
    /// </summary>
    [JsonPropertyName("upload_link")]
    public required string UploadLink { get; init; }

    /// <summary>
    /// The upload URI.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The owner of the uploaded video.
    /// </summary>
    [JsonPropertyName("user")]
    public required User User { get; init; }
}
