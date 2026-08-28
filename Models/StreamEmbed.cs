using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record StreamEmbed
{
    /// <summary>
    /// The embed permission level for the event.
    /// <para>
    /// Option descriptions:
    ///  * <c>private</c> - Only the user can embed the event.
    ///  * <c>public</c> - Anyone can embed the event.
    ///  * <c>whitelist</c> - Only specified users can embed the event.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embed")]
    public Embed8? Embed { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
