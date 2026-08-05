using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Information about the user's DRM usage quota.
/// </summary>
public record DrmLicensesQuota
{
    /// <summary>
    /// The maximum number of DRM sessions granted to the authenticated user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available")]
    public double? Available { get; init; }

    /// <summary>
    /// The time period for which the DRM usage activity is evaluated.
    /// <para>
    /// Option descriptions:
    ///  * <c>lifetime</c> - The quota period is for the lifetime of the account.
    ///  * <c>year</c> - The quota period is one year.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("period")]
    public Period2? Period { get; init; }

    /// <summary>
    /// The number of DRM sessions that are remaining for the authenticated user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remaining")]
    public double? Remaining { get; init; }

    /// <summary>
    /// The date of the user's next DRM sessions reset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reset_date")]
    public string? ResetDate { get; init; }

    /// <summary>
    /// The number of DRM sessions that have been consumed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("used")]
    public double? Used { get; init; }
}
