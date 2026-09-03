using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The authenticated user's account type.
/// <para>
/// Option descriptions:
///  * <c>advanced</c> - The user has a Vimeo Advanced account.
///  * <c>basic</c> - The user has a Vimeo Basic account.
///  * <c>business</c> - The user has a Vimeo Business account.
///  * <c>creator</c> - The user has a Vimeo Creator account.
///  * <c>custom</c> - The user has a Vimeo Custom account.
///  * <c>enterprise</c> - The user has a Vimeo Enterprise account.
///  * <c>free</c> - The user has a Vimeo Free account.
///  * <c>live_business</c> - The user has a Vimeo Business Live account.
///  * <c>live_premium</c> - The user has a Vimeo Premium account.
///  * <c>live_pro</c> - The user has a Vimeo Pro Live account.
///  * <c>ott_custom</c> - The user has a Vimeo OTT Custom account.
///  * <c>plus</c> - The user has a Vimeo Plus account.
///  * <c>pro</c> - The user has a Vimeo Pro account.
///  * <c>pro_unlimited</c> - The user has a Vimeo Pro Unlimited account.
///  * <c>producer</c> - The user has a Vimeo Producer account.
///  * <c>production</c> - The user has a Vimeo Production account.
///  * <c>professional</c> - The user has a Vimeo Professional account.
///  * <c>standard</c> - The user has a Vimeo Standard account.
///  * <c>starter</c> - The user has a Vimeo Starter account.
///  * <c>studio</c> - The user has a Vimeo Studio account.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : StringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 Advanced = new("advanced");

    public static readonly Type2 Basic = new("basic");

    public static readonly Type2 Business = new("business");

    public static readonly Type2 Creator = new("creator");

    public static readonly Type2 Custom = new("custom");

    public static readonly Type2 Enterprise = new("enterprise");

    public static readonly Type2 Free = new("free");

    public static readonly Type2 LiveBusiness = new("live_business");

    public static readonly Type2 LivePremium = new("live_premium");

    public static readonly Type2 LivePro = new("live_pro");

    public static readonly Type2 OttCustom = new("ott_custom");

    public static readonly Type2 Plus = new("plus");

    public static readonly Type2 Pro = new("pro");

    public static readonly Type2 ProUnlimited = new("pro_unlimited");

    public static readonly Type2 Producer = new("producer");

    public static readonly Type2 Production = new("production");

    public static readonly Type2 Professional = new("professional");

    public static readonly Type2 Standard = new("standard");

    public static readonly Type2 Starter = new("starter");

    public static readonly Type2 Studio = new("studio");

    public static Type2 FromValue(string value) => FromValueCore(value);
}
