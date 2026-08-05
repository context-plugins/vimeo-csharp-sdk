using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Items1
{
    /// <summary>
    /// The amount of the item.
    /// </summary>
    [JsonPropertyName("amount")]
    public required IReadOnlyList<object> Amount { get; init; }

    /// <summary>
    /// The time in 8601 format when the item was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// The time in 8601 format when the item ended.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_date")]
    public string? EndDate { get; init; }

    /// <summary>
    /// The ID of the item.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The metadata of the item.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public object? Metadata { get; init; }

    /// <summary>
    /// The ID of the price.
    /// </summary>
    [JsonPropertyName("price_id")]
    public required string PriceId { get; init; }

    /// <summary>
    /// The quantity of the item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required double Quantity { get; init; }

    /// <summary>
    /// The time in 8601 format when the item started.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_date")]
    public string? StartDate { get; init; }

    /// <summary>
    /// The ID of the subscription item.
    /// </summary>
    [JsonPropertyName("subscription_item_id")]
    public required string SubscriptionItemId { get; init; }

    /// <summary>
    /// The number of the subscription item.
    /// </summary>
    [JsonPropertyName("subscription_item_number")]
    public required string SubscriptionItemNumber { get; init; }

    /// <summary>
    /// The ID of the subscription plan.
    /// </summary>
    [JsonPropertyName("subscription_plan_id")]
    public required string SubscriptionPlanId { get; init; }

    /// <summary>
    /// The time in 8601 format when the item was synced.
    /// </summary>
    [JsonPropertyName("synced_at")]
    public required string SyncedAt { get; init; }

    /// <summary>
    /// The time in 8601 format when the item was updated.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required string UpdatedAt { get; init; }
}
