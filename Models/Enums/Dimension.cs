using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Dimension>))]
public sealed record Dimension : StringEnum<Dimension>
{
    private Dimension(string value) : base(value)
    {
    }

    public static readonly Dimension Browser = new("browser");

    public static readonly Dimension City = new("city");

    public static readonly Dimension Country = new("country");

    public static readonly Dimension DeviceType = new("device_type");

    public static readonly Dimension EmbedDomain = new("embed_domain");

    public static readonly Dimension EmbedDomainPath = new("embed_domain_path");

    public static readonly Dimension Os = new("os");

    public static readonly Dimension Region = new("region");

    public static readonly Dimension StreamingType = new("streaming_type");

    public static readonly Dimension Total = new("total");

    public static readonly Dimension Video = new("video");

    public static Dimension FromValue(string value) => FromValueCore(value);
}
