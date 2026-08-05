using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The preferred streaming method.
/// <para>
/// Option descriptions:
///  * <c>browser</c> - Stream in the browser.
///  * <c>encoder</c> - Stream by the encoder.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PreferredStreamMethod>))]
public sealed record PreferredStreamMethod : StringEnum<PreferredStreamMethod>
{
    private PreferredStreamMethod(string value) : base(value)
    {
    }

    public static readonly PreferredStreamMethod Browser = new("browser");

    public static readonly PreferredStreamMethod Encoder = new("encoder");

    public static PreferredStreamMethod FromValue(string value) => FromValueCore(value);
}
