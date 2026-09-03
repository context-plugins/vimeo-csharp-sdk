using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of access that the promotion grants.
/// <para>
/// Option descriptions:
///  * <c>default</c> - The promotion grants discounts on existing product offerings.
///  * <c>vip</c> - The promotion grants free access to On Demand content before it's released, or to access types that aren't part of the existing product offerings.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccessType>))]
public sealed record AccessType : StringEnum<AccessType>
{
    private AccessType(string value) : base(value)
    {
    }

    public static readonly AccessType Default = new("default");

    public static readonly AccessType Vip = new("vip");

    public static AccessType FromValue(string value) => FromValueCore(value);
}
