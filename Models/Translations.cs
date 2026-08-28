using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// Information about where and how to create a translation for the video.
/// </summary>
public record Translations
{
    /// <summary>
    /// Whether the translation method is disabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The reason why the translation method is disabled.
    /// <para>
    /// Option descriptions:
    ///  * <c>language_not_supported</c> - The video language isn't supported.
    ///  * <c>owner_account_blocked</c> - The owner account is blocked due to billing issues.
    ///  * <c>owner_disabled_feature_group</c> - The owner has disabled the feature group.
    ///  * <c>video_too_long</c> - The video is too long.
    /// </para>
    /// </summary>
    [JsonPropertyName("reason")]
    public required Reason8? Reason { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
