using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Option
{
    /// <summary>
    /// The replacement value. Required for rename and add; omit (or set to <c>null</c>) when deleting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("new_value")]
    public string? NewValue { get; init; }

    /// <summary>
    /// The existing value the operation targets. Required for rename and delete; omit (or set to <c>null</c>) when adding a new value.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("old_value")]
    public string? OldValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
