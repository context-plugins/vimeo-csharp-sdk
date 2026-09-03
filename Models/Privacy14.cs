using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Privacy14
{
    /// <summary>
    /// Whether a user can add the video to a showcase, channel, or group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("add")]
    public bool? Add { get; init; }

    /// <summary>
    /// The privacy level required to comment on the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can comment on the video.
    ///  * <c>contacts</c> - Only the video owner's contacts can comment on the video.
    ///  * <c>nobody</c> - No one can comment on the video.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("comments")]
    public Comments5? Comments { get; init; }

    /// <summary>
    /// Whether a user can download the video. This field isn't available to Vimeo Free members.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("download")]
    public bool? Download { get; init; }

    /// <summary>
    /// The video's embed setting. Specify the <c>whitelist</c> value to restrict embedding to a specific set of domains. For more information, see our <see href="https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy">Interacting with Videos</see> guide.
    /// <para>
    /// Option descriptions:
    ///  * <c>private</c> - The video can't be embedded.
    ///  * <c>public</c> - The video can be embedded.
    ///  * <c>whitelist</c> - The video can be embedded on the specified domains only.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed")]
    public Embed19? Embed { get; init; }

    /// <summary>
    /// The video's privacy setting. When this value is <c>users</c>, <c>application/json</c> is the only valid content type. Also, some privacy settings are unavailable to Vimeo Free members; for more information, see our <see href="https://vimeo.zendesk.com/hc/en-us/articles/224817847">Help Center</see>.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can access the video. This privacy setting appears as <c>Public</c> on the Vimeo front end.
    ///  * <c>contacts</c> - Only those who follow the owner on Vimeo can access the video. _This field is deprecated._
    ///  * <c>disable</c> - The video is embeddable, but it's hidden on Vimeo and can't be played. This privacy setting appears as <c>Embed only</c> on the Vimeo front end.
    ///  * <c>nobody</c> - No one except the owner can access the video. This privacy setting appears as <c>Private</c> on the Vimeo front end.
    ///  * <c>password</c> - Only those with the password can access the video.
    ///  * <c>team</c> - Anyone on the team can access the video. This privacy setting appears as <c>Company only</c> on the Vimeo front end.
    ///  * <c>unlisted</c> - Only those with the private link can access the video.
    ///  * <c>users</c> - Only Vimeo members can access the video. _This field is deprecated._
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("view")]
    public View14? View { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
