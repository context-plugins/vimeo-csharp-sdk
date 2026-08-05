using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record VideosRequest1
{
    /// <summary>
    /// A list of values describing the content in this video. For a full list of values, use the <see href="https://developer.vimeo.com/api/reference/videos#get_content_ratings"><c>/contentratings</c></see> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content_rating")]
    public IReadOnlyList<string>? ContentRating { get; init; }

    /// <summary>
    /// The custom link of the video. This link doesn't include the base URL and the username or user ID of the video's owner.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_url")]
    public string? CustomUrl { get; init; }

    /// <summary>
    /// The description of the video. This field can hold a maximum of 5000 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed")]
    public Embed29? Embed { get; init; }

    /// <summary>
    /// The complete list of domains the video can be embedded on. This field overwrites existing domains and requires that <b>privacy_embed</b> have the value <c>whitelist</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed_domains")]
    public IReadOnlyList<string>? EmbedDomains { get; init; }

    /// <summary>
    /// A list of domains intended to be added to an existing set of domains. This field requires that <b>privacy_embed</b> have the value <c>whitelist</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed_domains_add")]
    public IReadOnlyList<string>? EmbedDomainsAdd { get; init; }

    /// <summary>
    /// A list of domains intended to be removed from an existing set of domains. This field requires that <b>privacy_embed</b> have the value <c>whitelist</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed_domains_delete")]
    public IReadOnlyList<string>? EmbedDomainsDelete { get; init; }

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
    ///  * <c>cc0</c> - The video is offered under CC0, or public domain, videos.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("license")]
    public License4? License { get; init; }

    /// <summary>
    /// The video's default language. For a full list of supported languages, use the <see href="https://developer.vimeo.com/api/reference/videos#get_languages"><c>/languages?filter=texttracks</c></see> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    /// <summary>
    /// The title of the video. This field can hold a maximum of 128 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The password. When you set <b>privacy.view</b> to <c>password</c>, you must provide the password as an additional parameter. This field can hold a maximum of 32 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privacy")]
    public Privacy20? Privacy { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review_page")]
    public ReviewPage? ReviewPage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("spatial")]
    public Spatial3? Spatial { get; init; }
}
