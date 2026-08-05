using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the On Demand page's episodes, if the page is for a series.
/// </summary>
public record Episodes
{
    [JsonPropertyName("buy")]
    public required Buy1 Buy { get; init; }

    [JsonPropertyName("rent")]
    public required Rent1 Rent { get; init; }
}
