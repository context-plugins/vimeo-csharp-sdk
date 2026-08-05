using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the prices associated with the plan.
/// </summary>
public record Price
{
    /// <summary>
    /// The annual price, charged annually.
    /// </summary>
    [JsonPropertyName("annual")]
    public required double Annual { get; init; }

    /// <summary>
    /// The monthly price, charged annually.
    /// </summary>
    [JsonPropertyName("annual_monthly")]
    public required double AnnualMonthly { get; init; }

    /// <summary>
    /// The monthly price, charged monthly.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly")]
    public double? Monthly { get; init; }
}
