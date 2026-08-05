using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersAlbumsLogosLogoIdRequest
{
    /// <summary>
    /// Whether to make this image the active showcase logo.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}
