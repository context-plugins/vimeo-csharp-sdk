using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// A collection of information about the embeddable player's title bar.
/// </summary>
public record Title
{
    /// <summary>
    /// How the embeddable player handles the video title.
    /// <para>
    /// Option descriptions:
    ///  * <c>hide</c> - The title is hidden.
    ///  * <c>show</c> - The title is shown.
    ///  * <c>user</c> - The title can be toggled to <c>show</c> or <c>hide</c> by the user.
    /// </para>
    /// </summary>
    [JsonPropertyName("name")]
    public required Name Name { get; init; }

    /// <summary>
    /// How the embeddable player handles the video owner's information.
    /// <para>
    /// Option descriptions:
    ///  * <c>hide</c> - The owner's information is hidden.
    ///  * <c>show</c> - The owner's information is shown.
    ///  * <c>user</c> - The owner's information can be toggled to <c>show</c> or <c>hide</c> by the user.
    /// </para>
    /// </summary>
    [JsonPropertyName("owner")]
    public required Owner Owner { get; init; }

    /// <summary>
    /// How the embeddable player handles the video owner's portrait.
    /// <para>
    /// Option descriptions:
    ///  * <c>hide</c> - The owner's portrait is hidden
    ///  * <c>show</c> - The owner's portrait is shown.
    ///  * <c>user</c> - The owner's portrait can be toggled to <c>show</c> or <c>hide</c> by the user.
    /// </para>
    /// </summary>
    [JsonPropertyName("portrait")]
    public required Portrait Portrait { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
