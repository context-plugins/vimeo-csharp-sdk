using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersAlbumsCustomThumbnailsThumbnailIdRequest
{
    /// <summary>
    /// Whether to make this image the active custom showcase thumbnail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}
