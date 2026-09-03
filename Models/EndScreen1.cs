using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// A representation of the end screen settings.
/// </summary>
public record EndScreen1
{
    /// <summary>
    /// The custom image that appears after the video ends.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("image")]
    public Image? Image { get; init; }

    /// <summary>
    /// The links that appear after the video ends.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public Link? Link { get; init; }

    /// <summary>
    /// The share options that appear after the video ends.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("share")]
    public Share? Share { get; init; }

    /// <summary>
    /// The text block that appears after the video ends.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public Text? Text { get; init; }

    /// <summary>
    /// The elements that appear after the video ends.
    /// <para>
    /// Option descriptions:
    ///  * <c>beginning</c> - The end screen is a thumbnail.
    ///  * <c>custom</c> - The end screen is custom.
    ///  * <c>email</c> - The end screen is an email form.
    ///  * <c>image</c> - The end screen is an image.
    ///  * <c>link</c> - The end screen is a link.
    ///  * <c>loop</c> - The end screen is a loop.
    ///  * <c>nothing</c> - There is no end screen.
    ///  * <c>share</c> - The end screen is a share button.
    ///  * <c>text</c> - The end screen is text.
    ///  * <c>threevideos</c> - The end screen is three video suggestions.
    ///  * <c>videos</c> - The end screen is video suggestions.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type21 Type { get; init; }

    /// <summary>
    /// The additional videos that are offered after the main video ends.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("videos")]
    public Videos15? Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
