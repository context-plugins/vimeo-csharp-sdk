using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Graphic
{
    /// <summary>
    /// The unique identifier of the graphic item.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The type of the graphic item.
    /// <para>
    /// Option descriptions:
    ///  * <c>agoraMedia</c> - A generic preloaded video or image.
    ///  * <c>agoraScreen</c> - Shared screen content from an Agora user.
    ///  * <c>agoraStream</c> - A live video feed from an Agora participant.
    ///  * <c>broadcasterLowerthird</c> - The name and title for the main host.
    ///  * <c>fullscreen</c> - A screen-filling informational graphic.
    ///  * <c>guestLowerthird</c> - The name and title for a stream guest.
    ///  * <c>logo</c> - A branding or emblem image.
    ///  * <c>lowerthird</c> - The standard name and title text overlay.
    ///  * <c>poll</c> - Audience voting content and results.
    ///  * <c>qna</c> - Question and answer text display.
    ///  * <c>slides</c> - Presentation slide content.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type12 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
