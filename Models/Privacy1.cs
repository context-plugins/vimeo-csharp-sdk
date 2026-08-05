using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Privacy1
{
    /// <summary>
    /// Whether other users can add the authenticated user's videos.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("add")]
    public bool? Add { get; init; }

    /// <summary>
    /// Whether unlisted videos are hidden from Vimeo.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_share_link")]
    public bool? AllowShareLink { get; init; }

    /// <summary>
    /// The list of domains where the authenticated user can embed the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clip_embed_allowed_domains")]
    public IReadOnlyList<string>? ClipEmbedAllowedDomains { get; init; }

    /// <summary>
    /// The authenticated user's privacy preference for comments.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can comment on the user's videos.
    ///  * <c>contacts</c> - Only contacts can comment on the user's videos.
    ///  * <c>nobody</c> - No one can comment on the user's videos.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comments")]
    public Comments? Comments { get; init; }

    /// <summary>
    /// Whether other users can download the authenticated user's videos.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("download")]
    public bool? Download { get; init; }

    /// <summary>
    /// The authenticated user's privacy preference for embeds.
    /// <para>
    /// Option descriptions:
    ///  * <c>private</c> - Only the user can embed their own videos.
    ///  * <c>public</c> - Anyone can embed the user's videos.
    ///  * <c>whitelist</c> - Only specified users can embed the user's videos.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed")]
    public Embed? Embed { get; init; }

    /// <summary>
    /// The default password for the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    /// <summary>
    /// The authenticated user's privacy preference for views.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can view the user's videos. This privacy setting appears as <c>Public</c> on the Vimeo front end.
    ///  * <c>contacts</c> - Only contacts can view the user's videos. _This field is deprecated._
    ///  * <c>disable</c> - Views are disabled for the user's videos. This privacy setting appears as <c>Embed only</c> on the Vimeo front end.
    ///  * <c>nobody</c> - No one except the user can view the user's videos. This privacy setting appears as <c>Private</c> on the Vimeo front end.
    ///  * <c>password</c> - Only those with the password can view the user's videos.
    ///  * <c>unlisted</c> - Anybody can view the user's videos if they have a link.
    ///  * <c>users</c> - Only other Vimeo members can view the user's videos. _This field is deprecated._
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("view")]
    public View1? View { get; init; }
}
