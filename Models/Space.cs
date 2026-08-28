using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// Information about the authenticated user's upload space remaining for the current period.
/// </summary>
public record Space
{
    /// <summary>
    /// The number of bytes or videos remaining in the authenticated user's upload quota.
    /// </summary>
    [JsonPropertyName("free")]
    public required double Free { get; init; }

    /// <summary>
    /// The maximum number of bytes or videos allotted to the authenticated user's upload quota.
    /// </summary>
    [JsonPropertyName("max")]
    public required double? Max { get; init; }

    /// <summary>
    /// The type of quota for the values of the <b>upload_quota.space</b> field.
    /// <para>
    /// Option descriptions:
    ///  * <c>lifetime</c> - The quota type is lifetime.
    ///  * <c>periodic</c> - The quota type is periodic.
    /// </para>
    /// </summary>
    [JsonPropertyName("showing")]
    public required Showing Showing { get; init; }

    /// <summary>
    /// The unit that's used to compute quota.
    /// <para>
    /// Option descriptions:
    ///  * <c>video_count</c> - The quota is calculated using the count of the videos.
    ///  * <c>video_size</c> - The quota is calculated using the byte size of the videos.
    /// </para>
    /// </summary>
    [JsonPropertyName("unit")]
    public required Unit? Unit { get; init; }

    /// <summary>
    /// The number of bytes or videos that the authenticated user has already uploaded against their quota.
    /// </summary>
    [JsonPropertyName("used")]
    public required double Used { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
