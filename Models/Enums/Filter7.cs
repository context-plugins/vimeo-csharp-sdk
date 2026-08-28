using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter7>))]
public sealed record Filter7 : StringEnum<Filter7>
{
    private Filter7(string value) : base(value)
    {
    }

    public static readonly Filter7 Audiotracks = new("audiotracks");

    public static readonly Filter7 Texttracks = new("texttracks");

    public static Filter7 FromValue(string value) => FromValueCore(value);
}
