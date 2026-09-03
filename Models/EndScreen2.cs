using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record EndScreen2
{
    /// <summary>
    /// The end screen type.
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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type34? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
