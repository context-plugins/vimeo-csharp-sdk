using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Rent1
{
    /// <summary>
    /// Whether all the videos on the On Demand page can be rented as a whole.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// The rental period for the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>1 day</c> - The rental period is one day.
    ///  * <c>1 month</c> - The rental period is one month.
    ///  * <c>1 week</c> - The rental period is one week.
    ///  * <c>1 year</c> - The rental period is one year.
    ///  * <c>2 day</c> - The rental period is two days.
    ///  * <c>3 day</c> - The rental period is three days.
    ///  * <c>3 month</c> - The rental period is three months.
    ///  * <c>6 month</c> - The rental period is six months.
    ///  * <c>7 day</c> - The rental period is seven days.
    ///  * <c>24 hour</c> - The rental period is 24 hours.
    ///  * <c>30 day</c> - The rental period is 30 days.
    ///  * <c>48 hour</c> - The rental period is 48 hours.
    ///  * <c>60 day</c> - The rental period is 60 days.
    ///  * <c>72 hour</c> - The rental period is 72 hours.
    /// </para>
    /// </summary>
    [JsonPropertyName("period")]
    public required Period4? Period { get; init; }

    /// <summary>
    /// The default price to rent an episode.
    /// </summary>
    [JsonPropertyName("price")]
    public required double? Price { get; init; }
}
