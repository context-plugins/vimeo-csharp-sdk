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
[JsonConverter(typeof(StringEnumConverter<Type37>))]
public sealed record Type37 : StringEnum<Type37>
{
    private Type37(string value) : base(value)
    {
    }

    public static readonly Type37 Batch = new("batch");

    public static readonly Type37 Single = new("single");

    public static Type37 FromValue(string value) => FromValueCore(value);
}
