using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record MeFollowingRequest
{
    /// <summary>
    /// An array of user IDs for the authenticated user to follow.
    /// </summary>
    [JsonPropertyName("users")]
    public required IReadOnlyList<string> Users { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
