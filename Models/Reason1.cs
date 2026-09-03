using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Reason1
{
    /// <summary>
    /// An icon that represents the reason why available showcase presets are disabled. This data requires a bearer token with the <c>private</c> scope.
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
    public Icon1? Icon { get; init; }

    /// <summary>
    /// An explanation for the user about why available showcase presets are disabled. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
