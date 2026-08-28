using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Interactions2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("add_privacy_user")]
    public AddPrivacyUser? AddPrivacyUser { get; init; }

    /// <summary>
    /// Information about the block status of the authenticated user.
    /// </summary>
    [JsonPropertyName("block")]
    public required Block1 Block { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connected_apps")]
    public ConnectedApps1? ConnectedApps { get; init; }

    /// <summary>
    /// Information about the followed status of the authenticated user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("follow")]
    public Follow2? Follow { get; init; }

    /// <summary>
    /// Information about where and how to report the requested user.
    /// </summary>
    [JsonPropertyName("report")]
    public required Report Report { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
