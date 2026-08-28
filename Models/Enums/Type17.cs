using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Type17>))]
public sealed record Type17 : StringEnum<Type17>
{
    private Type17(string value) : base(value)
    {
    }

    public static readonly Type17 Bool = new("bool");

    public static readonly Type17 Date = new("date");

    public static readonly Type17 Int = new("int");

    public static readonly Type17 MultiSelect = new("multi-select");

    public static readonly Type17 Select = new("select");

    public static readonly Type17 Str = new("str");

    public static Type17 FromValue(string value) => FromValueCore(value);
}
