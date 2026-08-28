using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record ChannelsPrivacyUsersRequest
{
    /// <summary>
    /// The array of either the user URIs or the user IDs to permit to access the private channel.
    /// </summary>
    [JsonPropertyName("users")]
    public required IReadOnlyList<string> Users { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
