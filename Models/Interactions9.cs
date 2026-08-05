using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Interactions9
{
    [JsonPropertyName("report")]
    public required Report2 Report { get; init; }
}
