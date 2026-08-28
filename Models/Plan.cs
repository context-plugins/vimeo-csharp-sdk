using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Plan
{
    /// <summary>
    /// The amount of the plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Money? Amount { get; init; }

    /// <summary>
    /// The ID of the billing plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_plan_id")]
    public string? BillingPlanId { get; init; }

    /// <summary>
    /// The ID of the billing plan product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_plan_product_id")]
    public string? BillingPlanProductId { get; init; }

    /// <summary>
    /// The type of the billing plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_plan_type")]
    public string? BillingPlanType { get; init; }

    /// <summary>
    /// The time in 8601 format when the plan was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// The ID of the plan.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// An array of items in the plan.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<Items1> Items { get; init; }

    /// <summary>
    /// The metadata of the plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public object? Metadata { get; init; }

    /// <summary>
    /// The ID of the plan.
    /// </summary>
    [JsonPropertyName("plan_id")]
    public required string PlanId { get; init; }

    /// <summary>
    /// The ID of the product.
    /// </summary>
    [JsonPropertyName("product_id")]
    public required string ProductId { get; init; }

    /// <summary>
    /// The promotional code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("promo_code")]
    public string? PromoCode { get; init; }

    /// <summary>
    /// The ID of the promotional code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("promo_code_id")]
    public string? PromoCodeId { get; init; }

    /// <summary>
    /// The quantity of the plan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("quantity")]
    public double? Quantity { get; init; }

    /// <summary>
    /// The ID of the subscription plan.
    /// </summary>
    [JsonPropertyName("subscription_plan_id")]
    public required string SubscriptionPlanId { get; init; }

    /// <summary>
    /// The number of the subscription plan.
    /// </summary>
    [JsonPropertyName("subscription_plan_number")]
    public required string SubscriptionPlanNumber { get; init; }

    /// <summary>
    /// The type of the subscription plan.
    /// </summary>
    [JsonPropertyName("subscription_plan_type")]
    public required string SubscriptionPlanType { get; init; }

    /// <summary>
    /// The time in 8601 format when the plan was synced.
    /// </summary>
    [JsonPropertyName("synced_at")]
    public required string SyncedAt { get; init; }

    /// <summary>
    /// The time in 8601 format when the plan was updated.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required string UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
