using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The privacy settings of the showcase.
/// </summary>
public record Privacy5
{
    /// <summary>
    /// The showcase's password. This field appears only when <b>privacy.view</b> is <c>password</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    /// <summary>
    /// The access level of the showcase.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can access the showcase. This privacy setting appears as <c>Public</c> on the Vimeo front end.
    ///  * <c>embed_only</c> - The showcase doesn't appear on Vimeo, but the owner can embed it on other sites.
    ///  * <c>nobody</c> - No one can access the showacse, including the owner. This privacy setting appears as <c>Private</c> on the Vimeo front end.
    ///  * <c>password</c> - Only those with the password can access the showcase.
    ///  * <c>team</c> - Only the owner and members of the owner's team can access the showcase.
    ///  * <c>unlisted</c> - The showcase can't be accessed if the URL omits its unlisted hash.
    /// </para>
    /// </summary>
    [JsonPropertyName("view")]
    public required View6 View { get; init; }
}
