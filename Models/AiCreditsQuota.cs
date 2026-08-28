using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// Information about the user's AI credits quota.
/// </summary>
public record AiCreditsQuota
{
    /// <summary>
    /// The maximum number of AI credits granted to the authenticated user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("available")]
    public double? Available { get; init; }

    /// <summary>
    /// An array of objects listing the balances and expiration dates for the user's AI credits quota.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balances")]
    public IReadOnlyList<Balance>? Balances { get; init; }

    /// <summary>
    /// The time period for which the AI credit activity is evaluated.
    /// <para>
    /// Option descriptions:
    ///  * <c>lifetime</c> - The quota period is for the lifetime of the account.
    ///  * <c>month</c> - The quota period is one month.
    ///  * <c>week</c> - The quota period is one week.
    ///  * <c>year</c> - The quota period is one year.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("period")]
    public Period? Period { get; init; }

    /// <summary>
    /// The number of AI credits that are remaining for the authenticated user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remaining")]
    public double? Remaining { get; init; }

    /// <summary>
    /// The date of the user's next AI credits reset.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reset_date")]
    public string? ResetDate { get; init; }

    /// <summary>
    /// The number of AI credits that have been spent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("used")]
    public double? Used { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
