using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// The video's privacy setting.
/// </summary>
public record Privacy3
{
    /// <summary>
    /// Whether the video can be added to collections.
    /// </summary>
    [JsonPropertyName("add")]
    public required bool Add { get; init; }

    /// <summary>
    /// Whether the share link is usable.
    /// </summary>
    [JsonPropertyName("allow_share_link")]
    public required bool AllowShareLink { get; init; }

    /// <summary>
    /// The video's comment permission setting.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can comment on the video.
    ///  * <c>contacts</c> - Only contacts can comment on the video.
    ///  * <c>nobody</c> - No one can comment on the video.
    /// </para>
    /// </summary>
    [JsonPropertyName("comments")]
    public required Comments2 Comments { get; init; }

    /// <summary>
    /// Whether the video can be downloaded.
    /// </summary>
    [JsonPropertyName("download")]
    public required bool Download { get; init; }

    /// <summary>
    /// The video's embed permission setting.
    /// <para>
    /// Option descriptions:
    ///  * <c>private</c> - The video is private.
    ///  * <c>public</c> - Anyone can embed the video.
    ///  * <c>whitelist</c> - The video can be embedded on specific domains.
    /// </para>
    /// </summary>
    [JsonPropertyName("embed")]
    public required Embed1 Embed { get; init; }

    /// <summary>
    /// The original privacy setting the video had before its current privacy was restricted by the owner's plan. Populated in two cases: for cold-storage videos (<c>privacy.view = "purgatory"</c>), the privacy the video had before being moved to cold storage; for cold-privacy videos (<c>is_cold_privacy_restricted = true</c>), the original premium privacy (for example <c>unlisted</c>) that the free plan no longer supports while <c>privacy.view</c> is collapsed to <c>nobody</c>. Absent for videos that aren't restricted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("original_view")]
    public string? OriginalView { get; init; }

    /// <summary>
    /// The general privacy setting of the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can access the video. This privacy setting appears as <c>Public</c> on the Vimeo front end.
    ///  * <c>cold_storage</c> - The video is temporarily frozen because the owner exceeded their plan's storage limit. The video page renders with an in-player overlay.
    ///  * <c>contacts</c> - Only contacts can access the video. _This field is deprecated._
    ///  * <c>disable</c> - The video is hidden from Vimeo. This privacy setting appears as <c>Embed only</c> on the Vimeo front end.
    ///  * <c>nobody</c> - No one besides the owner can access the video. This privacy setting appears as <c>Private</c> on the Vimeo front end.
    ///  * <c>password</c> - Anyone with the video's password can access the video.
    ///  * <c>ptv</c> - The Vimeo On Demand video is accessible and searchable from Vimeo. _This field is deprecated._
    ///  * <c>ptvhide</c> - The Vimeo On Demand video is hidden from Vimeo. _This field is deprecated._
    ///  * <c>stock</c> - The stock footage is accessible and searchable from Vimeo. _This field is deprecated._
    ///  * <c>stock_purchased</c> - The purchased stock footage is accessible and searchable from Vimeo. _This field is deprecated._
    ///  * <c>team</c> - Anyone on the team can access the video. This privacy setting appears as <c>Company only</c> on the Vimeo front end.
    ///  * <c>unlisted</c> - The video is accessible but not searchable from Vimeo.
    ///  * <c>users</c> - Only Vimeo members can access the video. _This field is deprecated._
    /// </para>
    /// </summary>
    [JsonPropertyName("view")]
    public required View4 View { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
