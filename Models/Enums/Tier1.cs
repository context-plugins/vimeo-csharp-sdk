using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Tier1>))]
public sealed record Tier1 : StringEnum<Tier1>
{
    private Tier1(string value) : base(value)
    {
    }

    public static readonly Tier1 Advanced = new("advanced");

    public static readonly Tier1 Business = new("business");

    public static readonly Tier1 Free = new("free");

    public static readonly Tier1 LivePremium = new("live_premium");

    public static readonly Tier1 Plus = new("plus");

    public static readonly Tier1 Pro = new("pro");

    public static readonly Tier1 ProUnlimited = new("pro_unlimited");

    public static readonly Tier1 Standard = new("standard");

    public static readonly Tier1 Starter = new("starter");

    public static Tier1 FromValue(string value) => FromValueCore(value);
}
