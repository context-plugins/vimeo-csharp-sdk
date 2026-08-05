using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The promotion access type, which is a purchase option that isn't available in the On Demand container. Use the <b>download</b> and <b>stream_period</b> parameters to define additional characteristics for the <c>vip</c> type.
/// <para>
/// Option descriptions:
///  * <c>default</c> - The promotion grants a discount on the existing purchase options for an On Demand container.
///  * <c>vip</c> - The promotion grants free access to On Demand content before it's released.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccessType1>))]
public sealed record AccessType1 : StringEnum<AccessType1>
{
    private AccessType1(string value) : base(value)
    {
    }

    public static readonly AccessType1 Default = new("default");

    public static readonly AccessType1 Vip = new("vip");

    public static AccessType1 FromValue(string value) => FromValueCore(value);
}
