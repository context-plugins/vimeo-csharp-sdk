using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// A representation of the play button's settings.
/// </summary>
public record PlayButton
{
    /// <summary>
    /// The position of the play button within the embeddable player.
    /// <para>
    /// Option descriptions:
    ///  * <c>auto</c> - Use Vimeo's default positioning for the play button.
    ///  * <c>bottom</c> - The play button is positioned at the bottom of the player, except when in tiny mode.
    ///  * <c>center</c> - The play button is positioned in the center of the player.
    /// </para>
    /// </summary>
    [JsonPropertyName("position")]
    public required Position Position { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
