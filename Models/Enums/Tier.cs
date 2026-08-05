using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The plan type.
/// <para>
/// Option descriptions:
///  * <c>advanced</c> - The plan type is Vimeo Advanced.
///  * <c>basic</c> - The plan type is Vimeo Basic.
///  * <c>business</c> - The plan type is Vimeo Business.
///  * <c>core</c> - The plan type is Vimeo Core.
///  * <c>creator</c> - The plan type is Vimeo Creator.
///  * <c>customSelfServe</c> - The plan type is Vimeo Custom.
///  * <c>enterprise</c> - The plan type is Vimeo Enterprise.
///  * <c>free</c> - The plan type is Vimeo Free.
///  * <c>livePremium</c> - The plan type is Vimeo Premium.
///  * <c>ott</c> - The plan type is Vimeo OTT.
///  * <c>plus</c> - The plan type is Vimeo Plus.
///  * <c>pro</c> - The plan type is Vimeo Pro.
///  * <c>proSolution</c> - The plan type is Vimeo Pro Solution.
///  * <c>proUnlimited</c> - The plan type is Vimeo Pro Unlimited.
///  * <c>production</c> - The plan type is Vimeo Production.
///  * <c>professional</c> - The plan type is Vimeo Professional.
///  * <c>standard</c> - The plan type is Vimeo Standard.
///  * <c>starter</c> - The plan type is Vimeo Starter.
///  * <c>studio</c> - The plan type is Vimeo Studio.
///  * <c>team</c> - The plan type is Vimeo Team.
///  * <c>teamLive</c> - The plan type is Vimeo Team Live.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Tier>))]
public sealed record Tier : StringEnum<Tier>
{
    private Tier(string value) : base(value)
    {
    }

    public static readonly Tier Advanced = new("advanced");

    public static readonly Tier Basic = new("basic");

    public static readonly Tier Business = new("business");

    public static readonly Tier Core = new("core");

    public static readonly Tier Creator = new("creator");

    public static readonly Tier CustomSelfServe = new("customSelfServe");

    public static readonly Tier Enterprise = new("enterprise");

    public static readonly Tier Free = new("free");

    public static readonly Tier LivePremium = new("livePremium");

    public static readonly Tier Ott = new("ott");

    public static readonly Tier Plus = new("plus");

    public static readonly Tier Pro = new("pro");

    public static readonly Tier ProSolution = new("proSolution");

    public static readonly Tier ProUnlimited = new("proUnlimited");

    public static readonly Tier Production = new("production");

    public static readonly Tier Professional = new("professional");

    public static readonly Tier Standard = new("standard");

    public static readonly Tier Starter = new("starter");

    public static readonly Tier Studio = new("studio");

    public static readonly Tier Team = new("team");

    public static readonly Tier TeamLive = new("teamLive");

    public static Tier FromValue(string value) => FromValueCore(value);
}
