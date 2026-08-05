using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Balance
{
    /// <summary>
    /// The expiration date of the balance in ISO 8601 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration_date")]
    public string? ExpirationDate { get; init; }

    /// <summary>
    /// The number of AI credits that are remaining for the balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remaining")]
    public double? Remaining { get; init; }
}
