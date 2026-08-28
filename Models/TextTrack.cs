using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record TextTrack
{
    /// <summary>
    /// Whether the text track is active.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the text track was created.
    /// </summary>
    [JsonPropertyName("created_on")]
    public required string CreatedOn { get; init; }

    /// <summary>
    /// The name of the language.
    /// </summary>
    [JsonPropertyName("display_language")]
    public required string DisplayLanguage { get; init; }

    /// <summary>
    /// A map of read-only download URLs for the text track, keyed by file format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("download_links")]
    public DownloadLinks? DownloadLinks { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the URLs in <c>download_links</c> expire.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("download_links_expires_time")]
    public string? DownloadLinksExpiresTime { get; init; }

    /// <summary>
    /// The read-only URL of the text track file, intended for use with HLS playback.
    /// </summary>
    [JsonPropertyName("hls_link")]
    public required string HlsLink { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the read-only HLS playback text track file expires.
    /// </summary>
    [JsonPropertyName("hls_link_expires_time")]
    public required string HlsLinkExpiresTime { get; init; }

    /// <summary>
    /// The text track identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required double Id { get; init; }

    /// <summary>
    /// The language code for the text track. To see a full list, request <c>/languages?filter=texttrack</c>.
    /// </summary>
    [JsonPropertyName("language")]
    public required string? Language { get; init; }

    /// <summary>
    /// The read-only URL of the text track file. You can upload to this link when you create it for the first time.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the text track link expires.
    /// </summary>
    [JsonPropertyName("link_expires_time")]
    public required string LinkExpiresTime { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public Metadata27? Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the text track was last modified.
    /// </summary>
    [JsonPropertyName("modified_on")]
    public required string ModifiedOn { get; init; }

    /// <summary>
    /// The descriptive name of the text track.
    /// </summary>
    [JsonPropertyName("name")]
    public required string? Name { get; init; }

    /// <summary>
    /// The upload source of the text track.
    /// <para>
    /// Option descriptions:
    ///  * <c>autogen_alternate_audio</c> - The text track is automatically generated from alternate audio.
    ///  * <c>autogen_dubbed</c> - The text track is automatically generated from AI dubbing.
    ///  * <c>autogen_live_audio</c> - The text track is automatically generated from live audio.
    ///  * <c>autogen_source_audio</c> - The text track is automatically generated from source audio.
    ///  * <c>autogen_translated</c> - The text track is automatically generated from AI translation.
    ///  * <c>user_uploaded</c> - The text track is uploaded by a user.
    /// </para>
    /// </summary>
    [JsonPropertyName("provenance")]
    public required Provenance1 Provenance { get; init; }

    /// <summary>
    /// The read-only URL of the source text track file that was originally uploaded.
    /// </summary>
    [JsonPropertyName("source_link")]
    public required string SourceLink { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the read-only source text track link expires.
    /// </summary>
    [JsonPropertyName("source_link_expires_time")]
    public required string SourceLinkExpiresTime { get; init; }

    /// <summary>
    /// The type of text track.
    /// <para>
    /// Option descriptions:
    ///  * <c>captions</c> - The text track is for captions.
    ///  * <c>subtitles</c> - The text track is for subtitles.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type28? Type { get; init; }

    /// <summary>
    /// The relative URI of the text track.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The version of the text track. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("version")]
    public required double? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
