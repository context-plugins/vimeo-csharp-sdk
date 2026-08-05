using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of the promotion. When <b>access_type</b> is <c>vip</c>, the value for this parameter must be <c>batch</c>.
/// <para>
/// Option descriptions:
///  * <c>batch</c> - The promotion type that generates many random codes to use one time each.
///  * <c>single</c> - The promotion type that generates one code to use many times.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type41>))]
public sealed record Type41 : StringEnum<Type41>
{
    private Type41(string value) : base(value)
    {
    }

    public static readonly Type41 Batch = new("batch");

    public static readonly Type41 Single = new("single");

    public static Type41 FromValue(string value) => FromValueCore(value);
}
