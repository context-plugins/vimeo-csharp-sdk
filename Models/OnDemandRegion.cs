using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record OnDemandRegion
{
    /// <summary>
    /// The ISO 3166-1 alpha-2 code for this country.
    /// </summary>
    [JsonPropertyName("country_code")]
    public required string CountryCode { get; init; }

    /// <summary>
    /// The descriptive name of this country.
    /// </summary>
    [JsonPropertyName("country_name")]
    public required string CountryName { get; init; }

    /// <summary>
    /// The region container's relative URI.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
