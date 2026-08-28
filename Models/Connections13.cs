using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Connections13
{
    /// <summary>
    /// Information about the guest user who posted the comment.
    /// </summary>
    [JsonPropertyName("guest_user")]
    public required GuestUser GuestUser { get; init; }

    /// <summary>
    /// Information about the replies to the comment.
    /// </summary>
    [JsonPropertyName("replies")]
    public required Replies Replies { get; init; }

    /// <summary>
    /// Information about the user who posted the comment.
    /// </summary>
    [JsonPropertyName("user")]
    public required User1 User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
