using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The time period for which the DRM usage activity is evaluated.
/// <para>
/// Option descriptions:
///  * <c>lifetime</c> - The quota period is for the lifetime of the account.
///  * <c>year</c> - The quota period is one year.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Period2>))]
public sealed record Period2 : StringEnum<Period2>
{
    private Period2(string value) : base(value)
    {
    }

    public static readonly Period2 Lifetime = new("lifetime");

    public static readonly Period2 Year = new("year");

    public static Period2 FromValue(string value) => FromValueCore(value);
}
