using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Type12>))]
public sealed record Type12 : StringEnum<Type12>
{
    private Type12(string value) : base(value)
    {
    }

    public static readonly Type12 AgoraMedia = new("agoraMedia");

    public static readonly Type12 AgoraScreen = new("agoraScreen");

    public static readonly Type12 AgoraStream = new("agoraStream");

    public static readonly Type12 BroadcasterLowerthird = new("broadcasterLowerthird");

    public static readonly Type12 Fullscreen = new("fullscreen");

    public static readonly Type12 GuestLowerthird = new("guestLowerthird");

    public static readonly Type12 Logo = new("logo");

    public static readonly Type12 Lowerthird = new("lowerthird");

    public static readonly Type12 Poll = new("poll");

    public static readonly Type12 Qna = new("qna");

    public static readonly Type12 Slides = new("slides");

    public static Type12 FromValue(string value) => FromValueCore(value);
}
