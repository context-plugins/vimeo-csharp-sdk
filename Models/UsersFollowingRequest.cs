using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersFollowingRequest
{
    /// <summary>
    /// An array of user IDs for the authenticated user to follow.
    /// </summary>
    [JsonPropertyName("users")]
    public required IReadOnlyList<string> Users { get; init; }
}
