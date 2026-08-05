using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Information about where and how to create a text translation for the video.
/// </summary>
public record TextTranslations
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
    ///  * <c>owner_account_blocked</c> - The owner account is blocked due to billing issues.
    ///  * <c>owner_disabled_feature_group</c> - The owner has disabled the feature group.
    ///  * <c>owner_payment_disabled</c> - The owner account can't use the payments service.
    ///  * <c>transcript_status_does_not_exist</c> - The video transcript doesn't exist.
    /// </para>
    /// </summary>
    [JsonPropertyName("reason")]
    public required Reason7? Reason { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}
