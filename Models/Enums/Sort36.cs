using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort36>))]
public sealed record Sort36 : StringEnum<Sort36>
{
    private Sort36(string value) : base(value)
    {
    }

    public static readonly Sort36 Date = new("date");

    public static readonly Sort36 Default = new("default");

    public static readonly Sort36 ModifiedTime = new("modified_time");

    public static readonly Sort36 Name = new("name");

    public static readonly Sort36 PinnedOn = new("pinned_on");

    public static Sort36 FromValue(string value) => FromValueCore(value);
}
