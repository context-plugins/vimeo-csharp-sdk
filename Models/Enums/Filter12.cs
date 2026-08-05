using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter12>))]
public sealed record Filter12 : StringEnum<Filter12>
{
    private Filter12(string value) : base(value)
    {
    }

    public static readonly Filter12 Moderated = new("moderated");

    public static Filter12 FromValue(string value) => FromValueCore(value);
}
