using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type27>))]
public sealed record Type27 : StringEnum<Type27>
{
    private Type27(string value) : base(value)
    {
    }

    public static readonly Type27 All = new("all");

    public static readonly Type27 OneTime = new("one_time");

    public static readonly Type27 Recurring = new("recurring");

    public static Type27 FromValue(string value) => FromValueCore(value);
}
