using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Title2
{
    /// <summary>
    /// How to handle the video title in the title bar of the embeddable player.
    /// <para>
    /// Option descriptions:
    ///  * <c>hide</c> - Hide the video title.
    ///  * <c>show</c> - Show the video title.
    ///  * <c>user</c> - Enable the user to decide.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public Name1? Name { get; init; }

    /// <summary>
    /// How to handle the owner information in the title bar of the embeddable player.
    /// <para>
    /// Option descriptions:
    ///  * <c>hide</c> - Hide the owner info.
    ///  * <c>show</c> - Show the owner info.
    ///  * <c>user</c> - Enable the user to decide.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("owner")]
    public Owner2? Owner { get; init; }

    /// <summary>
    /// How to handle the owner portrait in the title bar of the embeddable player.
    /// <para>
    /// Option descriptions:
    ///  * <c>hide</c> - Hide the portrait.
    ///  * <c>show</c> - Show the portrait.
    ///  * <c>user</c> - Enable the user to decide.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("portrait")]
    public Portrait2? Portrait { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
