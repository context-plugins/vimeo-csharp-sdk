using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Purchase
{
    /// <summary>
    /// The purchase status of the product.
    /// <para>
    /// Option descriptions:
    ///  * <c>available</c> - The product is available for purchase.
    ///  * <c>purchased</c> - The product is already purchased.
    ///  * <c>unavailable</c> - The product isn't available for purchase.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status20 Status { get; init; }

    /// <summary>
    /// The redirect URIs associated with the plan.
    /// </summary>
    [JsonPropertyName("uri")]
    public required UriModel Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
