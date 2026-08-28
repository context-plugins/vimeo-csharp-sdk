using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record UsersVideosRequest1
{
    /// <summary>
    /// A list of values describing the content in this video. For a full list of values, use the <see href="https://developer.vimeo.com/api/reference/videos#get_content_ratings"><c>/contentratings</c></see> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content_rating")]
    public IReadOnlyList<string>? ContentRating { get; init; }

    /// <summary>
    /// The description of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed")]
    public Embed18? Embed { get; init; }

    /// <summary>
    /// The complete list of domains the video can be embedded on. This field requires that <b>privacy_embed</b> have the value <c>whitelist</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed_domains")]
    public IReadOnlyList<string>? EmbedDomains { get; init; }

    /// <summary>
    /// The URI of the folder to which the video is uploaded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("folder_uri")]
    public string? FolderUri { get; init; }

    /// <summary>
    /// Whether to hide the video from everyone except the video's owner. When the value is <c>true</c>, unlisted video links work only for the video's owner.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hide_from_vimeo")]
    public bool? HideFromVimeo { get; init; }

    /// <summary>
    /// The Creative Commons license under which the video is offered.
    /// <para>
    /// Option descriptions:
    ///  * <c>by</c> - The video is offered under CC BY, or the attibution-only license.
    ///  * <c>by-nc</c> - The video is offered under CC BY-NC, or the Attribution-NonCommercial license.
    ///  * <c>by-nc-nd</c> - The video is offered under CC BY-NC-ND, or the Attribution-NonCommercian-NoDerivs license.
    ///  * <c>by-nc-sa</c> - The video is offered under CC BY-NC-SA, or the Attribution-NonCommercial-ShareAlike licence.
    ///  * <c>by-nd</c> - The video is offered under CC BY-ND, or the Attribution-NoDerivs license.
    ///  * <c>by-sa</c> - The video is offered under CC BY-SA, or the Attribution-ShareAlike license.
    ///  * <c>cc0</c> - The video is offered under CC0, or the public domain license.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("license")]
    public License2? License { get; init; }

    /// <summary>
    /// The video's default language. For a full list of supported languages, use the <see href="https://developer.vimeo.com/api/reference/videos#get_languages"><c>/languages?filter=texttracks</c></see> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    /// <summary>
    /// The title of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The password. This field is required when <b>privacy.view</b> is <c>password</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privacy")]
    public Privacy14? Privacy { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review_page")]
    public ReviewPage? ReviewPage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("spatial")]
    public Spatial1? Spatial { get; init; }

    [JsonPropertyName("upload")]
    public required Upload2 Upload { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
