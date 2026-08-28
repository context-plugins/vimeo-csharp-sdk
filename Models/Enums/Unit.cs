using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The unit that's used to compute quota.
/// <para>
/// Option descriptions:
///  * <c>video_count</c> - The quota is calculated using the count of the videos.
///  * <c>video_size</c> - The quota is calculated using the byte size of the videos.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Unit>))]
public sealed record Unit : StringEnum<Unit>
{
    private Unit(string value) : base(value)
    {
    }

    public static readonly Unit VideoCount = new("video_count");

    public static readonly Unit VideoSize = new("video_size");

    public static Unit FromValue(string value) => FromValueCore(value);
}
