using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The privacy settings of the channel.
/// </summary>
public record Privacy
{
    /// <summary>
    /// The privacy setting of the channel.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can access the channel. This privacy setting appears as <c>Public</c> on the Vimeo front end.
    ///  * <c>moderators</c> - Only moderators can access the channel.
    ///  * <c>users</c> - Only registered users can access the channel. _This field is deprecated._
    /// </para>
    /// </summary>
    [JsonPropertyName("view")]
    public required View View { get; init; }
}
