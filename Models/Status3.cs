using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// An object containing data on the value of <b>status</b> and whether it's required for the interaction.
/// </summary>
public record Status3
{
    /// <summary>
    /// Whether the status of the role upgrade request must be sent to achieve the desired action.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; init; }

    /// <summary>
    /// The status of the role upgrade request to which the team member should have access.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
