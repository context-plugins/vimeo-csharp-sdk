using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort3>))]
public sealed record Sort3 : StringEnum<Sort3>
{
    private Sort3(string value) : base(value)
    {
    }

    public static readonly Sort3 LastVideoFeaturedTime = new("last_video_featured_time");

    public static readonly Sort3 Name = new("name");

    public static Sort3 FromValue(string value) => FromValueCore(value);
}
