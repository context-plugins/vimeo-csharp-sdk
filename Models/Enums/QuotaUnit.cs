using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The unit of the video storage for the user's periodic quota for the annual plan.
/// <para>
/// Option descriptions:
///  * <c>video_count</c> - The product has video storage based on video count.
///  * <c>video_size</c> - The product has video storage based on video size.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<QuotaUnit>))]
public sealed record QuotaUnit : StringEnum<QuotaUnit>
{
    private QuotaUnit(string value) : base(value)
    {
    }

    public static readonly QuotaUnit VideoCount = new("video_count");

    public static readonly QuotaUnit VideoSize = new("video_size");

    public static QuotaUnit FromValue(string value) => FromValueCore(value);
}
