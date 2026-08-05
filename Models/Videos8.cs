using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the videos associated with the On Demand page.
/// </summary>
public record Videos8
{
    /// <summary>
    /// The total number of extra videos on the On Demand page.
    /// </summary>
    [JsonPropertyName("extra_total")]
    public required double ExtraTotal { get; init; }

    /// <summary>
    /// The total number of main videos on the On Demand page.
    /// </summary>
    [JsonPropertyName("main_total")]
    public required double MainTotal { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The total number of videos on this connection.
    /// </summary>
    [JsonPropertyName("total")]
    public required double Total { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The total number of viewable videos on the On Demand page.
    /// </summary>
    [JsonPropertyName("viewable_total")]
    public required double ViewableTotal { get; init; }
}
