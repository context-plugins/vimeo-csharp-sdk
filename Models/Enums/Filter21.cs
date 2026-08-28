using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter21>))]
public sealed record Filter21 : StringEnum<Filter21>
{
    private Filter21(string value) : base(value)
    {
    }

    public static readonly Filter21 Folder = new("folder");

    public static readonly Filter21 LiveEvent = new("live_event");

    public static readonly Filter21 Video = new("video");

    public static Filter21 FromValue(string value) => FromValueCore(value);
}
