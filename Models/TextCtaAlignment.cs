using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Information about the alignment of the call-to-action text on the showcase page.
/// </summary>
public record TextCtaAlignment
{
    /// <summary>
    /// Whether an upgrade is required to align the call-to-action text on the showcase page.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// The alignment of the call-to-action text on the showcase page. Possible values include <c>center</c> for center alignment, <c>left</c> for left alignment, and <c>right</c> for right alignment.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
