using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The price map of the promotion.
/// </summary>
public record Price1
{
    /// <summary>
    /// The promotional annual price, charged annually.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annual")]
    public double? Annual { get; init; }

    /// <summary>
    /// The promotional monthly price, charged annually.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annual_monthly")]
    public double? AnnualMonthly { get; init; }

    /// <summary>
    /// The promotional monthly price, charged monthly.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly")]
    public double? Monthly { get; init; }
}
