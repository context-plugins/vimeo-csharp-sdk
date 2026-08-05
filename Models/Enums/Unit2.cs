using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The unit that's used to compute quota.
/// <para>
/// Option descriptions:
///  * <c>video_size</c> - The quota is calculated using the byte size of the videos.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Unit2>))]
public sealed record Unit2 : StringEnum<Unit2>
{
    private Unit2(string value) : base(value)
    {
    }

    public static readonly Unit2 VideoSize = new("video_size");

    public static Unit2 FromValue(string value) => FromValueCore(value);
}
