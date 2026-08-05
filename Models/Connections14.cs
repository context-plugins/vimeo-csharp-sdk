using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Connections14
{
    /// <summary>
    /// Information about the guest user who posted the comment.
    /// </summary>
    [JsonPropertyName("guest_user")]
    public required GuestUser GuestUser { get; init; }

    /// <summary>
    /// Information about the user who posted the reply.
    /// </summary>
    [JsonPropertyName("user")]
    public required User2 User { get; init; }
}
