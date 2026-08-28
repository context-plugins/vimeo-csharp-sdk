using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// An object containing information about how the authenticated user can interact with the video's On Demand page.
/// </summary>
public record Interactions13
{
    /// <summary>
    /// Information about how the authenticated user can interact with the connection to the video's On Demand page.
    /// </summary>
    [JsonPropertyName("page")]
    public required Page1 Page { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
