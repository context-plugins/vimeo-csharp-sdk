using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort48>))]
public sealed record Sort48 : StringEnum<Sort48>
{
    private Sort48(string value) : base(value)
    {
    }

    public static readonly Sort48 ModifiedAsc = new("modified_asc");

    public static readonly Sort48 ModifiedDesc = new("modified_desc");

    public static readonly Sort48 TitleAsc = new("title_asc");

    public static readonly Sort48 TitleDesc = new("title_desc");

    public static Sort48 FromValue(string value) => FromValueCore(value);
}
