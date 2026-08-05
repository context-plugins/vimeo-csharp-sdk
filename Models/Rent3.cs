using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Rent3
{
    /// <summary>
    /// Whether episodes can be rented.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// The rental period of the episode.
    /// <para>
    /// Option descriptions:
    ///  * <c>1 week</c> - The episode can be rented for a maximum of 1 week.
    ///  * <c>1 year</c> - The episode can be rented for a maximum of 1 year.
    ///  * <c>3 month</c> - The episode can be rented for a maximum of 3 months.
    ///  * <c>6 month</c> - The episode can be rented for a maximum of 6 months.
    ///  * <c>24 hour</c> - The episode can be rented for a maximum of 24 hours.
    ///  * <c>30 day</c> - The episode can be rented for a maximum of 30 days.
    ///  * <c>48 hour</c> - The episode can be rented for a maximum of 48 hours.
    ///  * <c>72 hour</c> - The episode can be rented for a maximum of 72 hours.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("period")]
    public Period5? Period { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public Price4? Price { get; init; }
}
