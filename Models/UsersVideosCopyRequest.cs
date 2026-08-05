using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersVideosCopyRequest
{
    /// <summary>
    /// The copied video name. By default, this becomes the source video name with (Copy) appended.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
