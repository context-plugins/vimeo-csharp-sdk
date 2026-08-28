using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter22>))]
public sealed record Filter22 : StringEnum<Filter22>
{
    private Filter22(string value) : base(value)
    {
    }

    public static readonly Filter22 AppOnly = new("app_only");

    public static readonly Filter22 ColdPrivacy = new("cold_privacy");

    public static readonly Filter22 ColdStorage = new("cold_storage");

    public static readonly Filter22 Embeddable = new("embeddable");

    public static readonly Filter22 Featured = new("featured");

    public static readonly Filter22 Live = new("live");

    public static readonly Filter22 NoPlaceholder = new("no_placeholder");

    public static readonly Filter22 Nolive = new("nolive");

    public static readonly Filter22 Playable = new("playable");

    public static readonly Filter22 ScreenRecorded = new("screen_recorded");

    public static Filter22 FromValue(string value) => FromValueCore(value);
}
