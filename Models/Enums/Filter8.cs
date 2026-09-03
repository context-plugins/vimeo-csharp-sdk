using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter8>))]
public sealed record Filter8 : StringEnum<Filter8>
{
    private Filter8(string value) : base(value)
    {
    }

    public static readonly Filter8 NotInFolder = new("not_in_folder");

    public static readonly Filter8 NotInShowcase = new("not_in_showcase");

    public static Filter8 FromValue(string value) => FromValueCore(value);
}
