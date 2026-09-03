using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Rent4
{
    /// <summary>
    /// Whether the video can be rented. This parameter is required when <b>episodes.rent.active</b> is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// The rental period of the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>1 week</c> - The video can be rented for a maximum of 1 week.
    ///  * <c>1 year</c> - The video can be rented for a maximum of 1 year.
    ///  * <c>3 month</c> - The video can be rented for a maximum of 3 months.
    ///  * <c>6 month</c> - The video can be rented for a maximum of 6 months.
    ///  * <c>24 hour</c> - The video can be rented for a maximum of 24 hours.
    ///  * <c>30 day</c> - The video can be rented for a maximum of 30 days.
    ///  * <c>48 hour</c> - The video can be rented for a maximum of 48 hours.
    ///  * <c>72 hour</c> - The video can be rented for a maximum of 72 hours.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("period")]
    public Period6? Period { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public Price5? Price { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
