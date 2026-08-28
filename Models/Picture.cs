using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Picture
{
    /// <summary>
    /// Whether the picture is currently active.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// The base link to the image file, without any parameters.
    /// </summary>
    [JsonPropertyName("base_link")]
    public required string BaseLink { get; init; }

    /// <summary>
    /// Whether the picture is Vimeo's default.
    /// </summary>
    [JsonPropertyName("default_picture")]
    public required bool DefaultPicture { get; init; }

    /// <summary>
    /// The upload URL of the picture. This field appears upon the initial creation of a picture resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }

    /// <summary>
    /// The resource key string of the picture.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// An array containing reference information about all available image files.
    /// </summary>
    [JsonPropertyName("sizes")]
    public required IReadOnlyList<Size> Sizes { get; init; }

    /// <summary>
    /// The type of picture.
    /// <para>
    /// Option descriptions:
    ///  * <c>caution</c> - The picture isn't appropriate for all ages.
    ///  * <c>custom</c> - The picture is a custom video image.
    ///  * <c>default</c> - The picture is the default video image.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required TypeEnum Type { get; init; }

    /// <summary>
    /// The URI of the picture.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
