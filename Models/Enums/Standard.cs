using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Standard>))]
public sealed record Standard : StringEnum<Standard>
{
    private Standard(string value) : base(value)
    {
    }

    public static readonly Standard Aicc = new("aicc");

    public static readonly Standard Cmi5 = new("cmi5");

    public static readonly Standard Scorm12 = new("scorm12");

    public static readonly Standard Scorm20043Rd = new("scorm2004_3rd");

    public static readonly Standard Tincan = new("tincan");

    public static Standard FromValue(string value) => FromValueCore(value);
}
