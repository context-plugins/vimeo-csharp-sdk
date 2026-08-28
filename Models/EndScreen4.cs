using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record EndScreen4
{
    /// <summary>
    /// The end screen type.
    /// <para>
    /// Option descriptions:
    ///  * <c>empty</c> - The end screen is empty.
    ///  * <c>loop</c> - The end screen loops the video playback.
    ///  * <c>share</c> - The end screen includes sharing options.
    ///  * <c>thumbnail</c> - The end screen includes the thumbnail of the video.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type40? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
