using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Reason
{
    /// <summary>
    /// An icon that represents the reason why showcase presets are disabled. This data requires a bearer token with the <c>private</c> scope.
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
    public Icon? Icon { get; init; }

    /// <summary>
    /// An explanation for the user about why showcase presets are disabled. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
