using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The navbar logo configuration of the event landing page, or <c>null</c> when the event was never configured (default rendering).
/// </summary>
public record LandingPageLogo
{
    /// <summary>
    /// Which logo to show in the landing page navbar.
    /// <para>
    /// Option descriptions:
    ///  * <c>custom</c> - A custom brand-kit logo (see <c>uri</c>/<c>url</c>).
    ///  * <c>none</c> - No logo is shown.
    ///  * <c>vimeo</c> - The Vimeo logo.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type18 Type { get; init; }

    /// <summary>
    /// Brand-kit logo resource URI (custom only).
    /// </summary>
    [JsonPropertyName("uri")]
    public required string? Uri { get; init; }

    /// <summary>
    /// Brand-kit logo image URL (custom only).
    /// </summary>
    [JsonPropertyName("url")]
    public required string? Url { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
