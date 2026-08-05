using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing the button to start watching.
/// </summary>
public record ShowStartWatchingButton
{
    /// <summary>
    /// Whether an upgrade is required for showing the button to start watching.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the button to start watching.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}
