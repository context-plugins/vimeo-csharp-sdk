using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record ReportReasonGenderedVariant
{
    /// <summary>
    /// A human-readable description of the gendered variant.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>
    /// The display name of the gendered variant.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The opaque reason UUID to submit when the target is a woman or girl.
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
