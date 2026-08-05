using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Privacy10
{
    /// <summary>
    /// Whether the user can add videos to showcases, channels, or groups by default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("add")]
    public bool? Add { get; init; }

    /// <summary>
    /// Who can comment on the user's video uploads by default.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can comment.
    ///  * <c>contacts</c> - Only the user's contacts can comment.
    ///  * <c>nobody</c> - No one can comment.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comments")]
    public Comments4? Comments { get; init; }

    /// <summary>
    /// Whether the user can download videos. This value becomes the default download setting for all future videos that the user uploads.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("download")]
    public bool? Download { get; init; }

    /// <summary>
    /// The privacy for the user's embedded videos. The <c>whitelist</c> value enables you to define all valid embeddable domains. See our <see href="https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy">Interacting with Videos</see> guide for details on adding and removing domains.
    /// <para>
    /// Option descriptions:
    ///  * <c>private</c> - The videos can't be embedded on any domain.
    ///  * <c>public</c> - The videos can be embedded on any domain.
    ///  * <c>whitelist</c> - The videos can be embedded on the specified domains only.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed")]
    public Embed11? Embed { get; init; }

    /// <summary>
    /// An array of the user's default list of valid domains for embedding videos.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed_allowed_domains")]
    public IReadOnlyList<string>? EmbedAllowedDomains { get; init; }

    /// <summary>
    /// Who can access the user's videos by default.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can access the videos. This privacy setting appears as <c>Public</c> on the Vimeo front end.
    ///  * <c>contacts</c> - Only the user's contacts can access the videos. _This field is deprecated._
    ///  * <c>disable</c> - The videos are disabled. This privacy setting appears as <c>Embed only</c> on the Vimeo front end.
    ///  * <c>nobody</c> - No one can access the videos. This privacy setting appears as <c>Private</c> on the Vimeo front end.
    ///  * <c>password</c> - Only those with the password can access the videos.
    ///  * <c>unlisted</c> - The videos are unlisted.
    ///  * <c>users</c> - Only other Vimeo members can access the videos. _This field is deprecated._
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("view")]
    public View11? View { get; init; }
}
