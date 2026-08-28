using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Location
{
    /// <summary>
    /// The authenticated user's city.
    /// </summary>
    [JsonPropertyName("city")]
    public required string? City { get; init; }

    /// <summary>
    /// The authenticated user's country.
    /// </summary>
    [JsonPropertyName("country")]
    public required string? Country { get; init; }

    /// <summary>
    /// The ISO code of the authenticated user's country.
    /// </summary>
    [JsonPropertyName("country_iso_code")]
    public required string CountryIsoCode { get; init; }

    /// <summary>
    /// The authenticated user's formatted address string.
    /// </summary>
    [JsonPropertyName("formatted_address")]
    public required string FormattedAddress { get; init; }

    /// <summary>
    /// The authenticated user's latitude.
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; init; }

    /// <summary>
    /// The authenticated user's longitude.
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; init; }

    /// <summary>
    /// The authenticated user's neighborhood.
    /// </summary>
    [JsonPropertyName("neighborhood")]
    public required string? Neighborhood { get; init; }

    /// <summary>
    /// The authenticated user's state.
    /// </summary>
    [JsonPropertyName("state")]
    public required string? State { get; init; }

    /// <summary>
    /// The ISO code of the authenticated user's state.
    /// </summary>
    [JsonPropertyName("state_iso_code")]
    public required string? StateIsoCode { get; init; }

    /// <summary>
    /// The authenticated user's sub-locality.
    /// </summary>
    [JsonPropertyName("sub_locality")]
    public required string? SubLocality { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
