using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Information about the associated showcase.
/// </summary>
public record Album2
{
    /// <summary>
    /// The responsive embed code for the associated showcase.
    /// </summary>
    [JsonPropertyName("embed_code")]
    public required string EmbedCode { get; init; }

    /// <summary>
    /// The ID of the associated showcase.
    /// </summary>
    [JsonPropertyName("id")]
    public required double Id { get; init; }

    /// <summary>
    /// The privacy setting of the associated showcase.
    /// </summary>
    [JsonPropertyName("privacy")]
    public required string Privacy { get; init; }

    /// <summary>
    /// The title of the associated showcase.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
