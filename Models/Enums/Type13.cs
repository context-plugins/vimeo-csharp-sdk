using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The data type of the metadata field.
/// <para>
/// Option descriptions:
///  * <c>bool</c> - Boolean value.
///  * <c>date</c> - Date value.
///  * <c>int</c> - Integer value.
///  * <c>multi-select</c> - Multi-select from allowed values.
///  * <c>select</c> - Single-select from allowed values.
///  * <c>str</c> - String value.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type13>))]
public sealed record Type13 : StringEnum<Type13>
{
    private Type13(string value) : base(value)
    {
    }

    public static readonly Type13 Bool = new("bool");

    public static readonly Type13 Date = new("date");

    public static readonly Type13 Int = new("int");

    public static readonly Type13 MultiSelect = new("multi-select");

    public static readonly Type13 Select = new("select");

    public static readonly Type13 Str = new("str");

    public static Type13 FromValue(string value) => FromValueCore(value);
}
