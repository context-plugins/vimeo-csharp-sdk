using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The restricted video storage quota (for embeddable and private videos).
/// </summary>
public record Restricted
{
    /// <summary>
    /// The number of bytes remaining in the authenticated user's restricted video storage quota.
    /// </summary>
    [JsonPropertyName("free")]
    public required double? Free { get; init; }

    /// <summary>
    /// The total number of bytes that the authenticated user can use for restricted videos (embeddable or private).
    /// </summary>
    [JsonPropertyName("max")]
    public required double? Max { get; init; }

    /// <summary>
    /// The unit that's used to compute quota.
    /// <para>
    /// Option descriptions:
    ///  * <c>video_size</c> - The quota is calculated using the byte size of the videos.
    /// </para>
    /// </summary>
    [JsonPropertyName("unit")]
    public required Unit2 Unit { get; init; }

    /// <summary>
    /// The number of bytes that the authenticated user has already used for restricted videos.
    /// </summary>
    [JsonPropertyName("used")]
    public required double Used { get; init; }
}
