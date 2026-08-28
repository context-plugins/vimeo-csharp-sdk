using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort78>))]
public sealed record Sort78 : StringEnum<Sort78>
{
    private Sort78(string value) : base(value)
    {
    }

    public static readonly Sort78 Default = new("default");

    public static Sort78 FromValue(string value) => FromValueCore(value);
}
