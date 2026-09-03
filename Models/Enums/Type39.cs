using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The data type of the field. Required when creating a new field. <b>Immutable</b> after creation.
/// <para>
/// Option descriptions:
///  * <c>bool</c> - Boolean value (<c>true</c> or <c>false</c>).
///  * <c>date</c> - Calendar date in <c>YYYY-MM-DD</c> format.
///  * <c>int</c> - Integer value.
///  * <c>multi-select</c> - One or more values chosen from the field's <c>values</c> list.
///  * <c>select</c> - A single value chosen from the field's <c>values</c> list.
///  * <c>str</c> - Freeform string value.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type39>))]
public sealed record Type39 : StringEnum<Type39>
{
    private Type39(string value) : base(value)
    {
    }

    public static readonly Type39 Bool = new("bool");

    public static readonly Type39 Date = new("date");

    public static readonly Type39 Int = new("int");

    public static readonly Type39 MultiSelect = new("multi-select");

    public static readonly Type39 Select = new("select");

    public static readonly Type39 Str = new("str");

    public static Type39 FromValue(string value) => FromValueCore(value);
}
