using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The unit of the video storage for the user's periodic quota for the annual plan.
/// <para>
/// Option descriptions:
///  * <c>video_count</c> - The product has video storage based on video count.
///  * <c>video_size</c> - The product has video storage based on video size.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VideoStorageQuotaUnit>))]
public sealed record VideoStorageQuotaUnit : StringEnum<VideoStorageQuotaUnit>
{
    private VideoStorageQuotaUnit(string value) : base(value)
    {
    }

    public static readonly VideoStorageQuotaUnit VideoCount = new("video_count");

    public static readonly VideoStorageQuotaUnit VideoSize = new("video_size");

    public static VideoStorageQuotaUnit FromValue(string value) => FromValueCore(value);
}
