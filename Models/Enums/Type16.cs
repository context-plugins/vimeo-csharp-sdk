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
[JsonConverter(typeof(StringEnumConverter<Type16>))]
public sealed record Type16 : StringEnum<Type16>
{
    private Type16(string value) : base(value)
    {
    }

    public static readonly Type16 AgoraMedia = new("agoraMedia");

    public static readonly Type16 AgoraScreen = new("agoraScreen");

    public static readonly Type16 AgoraStream = new("agoraStream");

    public static readonly Type16 BroadcasterLowerthird = new("broadcasterLowerthird");

    public static readonly Type16 Fullscreen = new("fullscreen");

    public static readonly Type16 GuestLowerthird = new("guestLowerthird");

    public static readonly Type16 Logo = new("logo");

    public static readonly Type16 Lowerthird = new("lowerthird");

    public static readonly Type16 Poll = new("poll");

    public static readonly Type16 Qna = new("qna");

    public static readonly Type16 Slides = new("slides");

    public static Type16 FromValue(string value) => FromValueCore(value);
}
