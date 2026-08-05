using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Play
{
    /// <summary>
    /// The DASH video file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dash")]
    public HlsDashVideoFile? Dash { get; init; }

    /// <summary>
    /// The HLS video file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hls")]
    public HlsDashVideoFile? Hls { get; init; }

    /// <summary>
    /// The player URL hosting the FairPlay certification that's required for the digital rights management playback.
    /// </summary>
    [JsonPropertyName("player_fairplay_certificate_url")]
    public required string PlayerFairplayCertificateUrl { get; init; }

    /// <summary>
    /// The player license URL related to DRM playback.
    /// </summary>
    [JsonPropertyName("player_license_url")]
    public required string PlayerLicenseUrl { get; init; }

    /// <summary>
    /// The progressive video files.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("progressive")]
    public IReadOnlyList<Progressive>? Progressive { get; init; }

    /// <summary>
    /// The play status of the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>drm_plays_exceeded</c> - The user's quota for DRM plays has been exceeded.
    ///  * <c>playable</c> - The video is playable.
    ///  * <c>purchase_required</c> - The video must be purchased.
    ///  * <c>restricted</c> - Playback for the video is restricted.
    ///  * <c>unavailable</c> - The video is unavailable.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status4 Status { get; init; }
}
