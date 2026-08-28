using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Videos4
{
    /// <summary>
    /// Whether the user has automatic review link generation enabled by default.
    /// </summary>
    [JsonPropertyName("auto_generate_review_link")]
    public required bool AutoGenerateReviewLink { get; init; }

    /// <summary>
    /// Whether the user has automatic closed captions enabled by default.
    /// </summary>
    [JsonPropertyName("autocc_display_enabled_by_default")]
    public required bool AutoccDisplayEnabledByDefault { get; init; }

    /// <summary>
    /// The URI of the user's embed preset preference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed_preset_uri")]
    public string? EmbedPresetUri { get; init; }

    /// <summary>
    /// Whether the user has hidden stats enabled by default.
    /// </summary>
    [JsonPropertyName("hide_stats")]
    public required bool HideStats { get; init; }

    /// <summary>
    /// Whether the user keeps source files after upload.
    /// </summary>
    [JsonPropertyName("keep_source_files")]
    public required bool KeepSourceFiles { get; init; }

    /// <summary>
    /// The <see href="http://creativecommons.org/licenses/">Creative Commons</see> license that the user has set to be the default.
    /// <para>
    /// Option descriptions:
    ///  * <c>by</c> - The video is given under the Attribution license.
    ///  * <c>by-nc</c> - The video is given under the Attribution Non-Commercial license.
    ///  * <c>by-nc-nd</c> - The video is given under the Attribution Non-Commercial No Derivatives license.
    ///  * <c>by-nc-sa</c> - The video is given under the Attribution Non-Commercial Share Alike license.
    ///  * <c>by-nd</c> - The video is given under the Attribution No Derivatives license.
    ///  * <c>by-sa</c> - The video is given under the Attribution Share Alike license.
    ///  * <c>cc0</c> - The video is given under the Public Domain Dedication license.
    /// </para>
    /// </summary>
    [JsonPropertyName("license")]
    public required License? License { get; init; }

    /// <summary>
    /// The URI of the user's video page preset preference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page_preset_uri")]
    public string? PagePresetUri { get; init; }

    /// <summary>
    /// The password for viewing the authenticated user's videos.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privacy")]
    public Privacy1? Privacy { get; init; }

    /// <summary>
    /// An array of the authorized user's default content ratings.
    /// <para>
    /// Option descriptions:
    ///  * <c>drugs</c> - The video contains drug or alcohol use.
    ///  * <c>language</c> - The video contains profanity or sexually suggestive content.
    ///  * <c>nudity</c> - The video contains nudity.
    ///  * <c>safe</c> - The video is suitable for all audiences.
    ///  * <c>unrated</c> - The video hasn't been rated.
    ///  * <c>violence</c> - The video contains violent or graphic content.
    /// </para>
    /// </summary>
    [JsonPropertyName("rating")]
    public required Rating Rating { get; init; }

    /// <summary>
    /// Default number of days until a sharing link expires. 0 means no expiration.
    /// </summary>
    [JsonPropertyName("sharing_link_default_expiry_days")]
    public required double SharingLinkDefaultExpiryDays { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
