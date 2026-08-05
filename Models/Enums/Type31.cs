using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type31>))]
public sealed record Type31 : StringEnum<Type31>
{
    private Type31(string value) : base(value)
    {
    }

    public static readonly Type31 All = new("all");

    public static readonly Type31 OneTime = new("one_time");

    public static readonly Type31 Recurring = new("recurring");

    public static Type31 FromValue(string value) => FromValueCore(value);
}
