using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record VideosCategoriesRequest
{
    /// <summary>
    /// An array of the names of the desired categories.
    /// </summary>
    [JsonPropertyName("category")]
    public required IReadOnlyList<string> Category { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
