using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Reason2
{
    /// <summary>
    /// An icon that represents the reason why publish-to-social presets are disabled.
    /// <para>
    /// Option descriptions:
    ///  * <c>clock</c> - The reason is represented by a clock icon.
    ///  * <c>create</c> - The reason is represented by a create icon.
    ///  * <c>image</c> - The reason is represented by an image icon.
    ///  * <c>theme</c> - The reason is represented by a theme icon.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("icon")]
    public Icon2? Icon { get; init; }

    /// <summary>
    /// An explanation for the user about why publish-to-social presets are disabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
