using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Interactions6
{
    /// <summary>
    /// Interactions for On Demand pages that belong to the genre.
    /// </summary>
    [JsonPropertyName("page")]
    public required Page Page { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
