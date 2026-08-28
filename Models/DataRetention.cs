using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record DataRetention
{
    /// <summary>
    /// Information about the folder's data retention policy. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("policy")]
    public required Policy Policy { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
