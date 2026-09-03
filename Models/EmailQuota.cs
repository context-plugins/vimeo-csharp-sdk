using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Information about the event owner's email quota.
/// </summary>
public record EmailQuota
{
    /// <summary>
    /// The maximum number of entity emails that the user can send.
    /// </summary>
    [JsonPropertyName("capping")]
    public required double Capping { get; init; }

    /// <summary>
    /// The current number of entity emails that the user has sent.
    /// </summary>
    [JsonPropertyName("total")]
    public required double Total { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
