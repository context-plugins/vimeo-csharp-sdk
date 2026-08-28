using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The authenticated user's membership level.
/// <para>
/// Option descriptions:
///  * <c>Advanced</c> - The user has an Advanced subscription.
///  * <c>Basic</c> - The user has a Vimeo Basic subscription.
///  * <c>Business</c> - The user has a Vimeo Business subscription.
///  * <c>Business Live</c> - The user has a Vimeo Business Live subscription.
///  * <c>Creator</c> - The user has a Vimeo Creator subscription.
///  * <c>Custom</c> - The user has a Vimeo Custom subscription.
///  * <c>Free</c> - The user has a Free subscription.
///  * <c>Ott Custom</c> - The user has a Vimeo OTT Custom subscription.
///  * <c>Plus</c> - The user has a Vimeo Plus subscription.
///  * <c>Premium</c> - The user has a Vimeo Premium subscription.
///  * <c>Pro</c> - The user has a Vimeo Pro subscription.
///  * <c>Pro Live</c> - The user has a Vimeo Pro Live subscription.
///  * <c>Pro Unlimited</c> - The user has a Vimeo Pro Unlimited subscription.
///  * <c>Producer</c> - The user has a Vimeo Producer subscription.
///  * <c>Production</c> - The user has a Vimeo Production subscription.
///  * <c>Professional</c> - The user has a Vimeo Professional subscription.
///  * <c>Standard</c> - The user has a Vimeo Standard subscription.
///  * <c>Starter</c> - The user has a Vimeo Starter subscription.
///  * <c>Studio</c> - The user has a Vimeo Studio subscription.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Display>))]
public sealed record Display : StringEnum<Display>
{
    private Display(string value) : base(value)
    {
    }

    public static readonly Display Advanced = new("Advanced");

    public static readonly Display Basic = new("Basic");

    public static readonly Display Business = new("Business");

    public static readonly Display BusinessLive = new("Business Live");

    public static readonly Display Creator = new("Creator");

    public static readonly Display Custom = new("Custom");

    public static readonly Display Free = new("Free");

    public static readonly Display OttCustom = new("Ott Custom");

    public static readonly Display Plus = new("Plus");

    public static readonly Display Premium = new("Premium");

    public static readonly Display Pro = new("Pro");

    public static readonly Display ProLive = new("Pro Live");

    public static readonly Display ProUnlimited = new("Pro Unlimited");

    public static readonly Display Producer = new("Producer");

    public static readonly Display Production = new("Production");

    public static readonly Display Professional = new("Professional");

    public static readonly Display Standard = new("Standard");

    public static readonly Display Starter = new("Starter");

    public static readonly Display Studio = new("Studio");

    public static Display FromValue(string value) => FromValueCore(value);
}
