using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Preferences
{
    [JsonPropertyName("videos")]
    public required Videos4 Videos { get; init; }
}
