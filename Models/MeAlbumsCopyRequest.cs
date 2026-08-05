using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record MeAlbumsCopyRequest
{
    /// <summary>
    /// The copied showcase name. By default, this becomes the source showcase name with (Copy) appended.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
