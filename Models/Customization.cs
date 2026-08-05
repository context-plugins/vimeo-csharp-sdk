using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The contents of the page customization group (background color, title font, and inline logo).
/// </summary>
public record Customization
{
    /// <summary>
    /// Whether to render the ambient backlight glow behind the video player on the page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ambient_backlight")]
    public bool? AmbientBacklight { get; init; }

    /// <summary>
    /// The page background color as a <c>#</c>-prefixed hex string, or null if not set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("background_color")]
    public string? BackgroundColor { get; init; }

    /// <summary>
    /// Whether to hide the Vimeo header (top navigation bar) on the video page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hide_vimeo_header")]
    public bool? HideVimeoHeader { get; init; }

    /// <summary>
    /// Optional logo to display inline with the video title.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("logo")]
    public Logo? Logo { get; init; }

    /// <summary>
    /// The selected video title font family.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title_font_family")]
    public TitleFontFamily? TitleFontFamily { get; init; }

    /// <summary>
    /// The selected video title font weight.
    /// <para>
    /// Option descriptions:
    ///  * <c>300</c> - Light
    ///  * <c>400</c> - Regular
    ///  * <c>500</c> - Medium
    ///  * <c>700</c> - Bold
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title_font_weight")]
    public TitleFontWeight? TitleFontWeight { get; init; }
}
