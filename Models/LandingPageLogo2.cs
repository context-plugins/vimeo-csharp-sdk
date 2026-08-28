using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// The navbar logo configuration of the event landing page.
/// </summary>
public record LandingPageLogo2
{
    /// <summary>
    /// Which logo to show in the landing page navbar.
    /// <para>
    /// Option descriptions:
    ///  * <c>custom</c> - A custom brand-kit logo (see <c>uri</c>).
    ///  * <c>none</c> - No logo is shown.
    ///  * <c>vimeo</c> - The Vimeo logo.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type32? Type { get; init; }

    /// <summary>
    /// Brand-kit logo resource URI. Required when <c>type</c> is <c>custom</c>. The display URL is derived server-side from this URI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
