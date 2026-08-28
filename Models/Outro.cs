using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Outro
{
    /// <summary>
    /// A comma-separated list of video URIs. This field appears only when <b>type</b> is <c>uploaded_clips</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clips")]
    public string? Clips { get; init; }

    /// <summary>
    /// The outro link settings. These fields appear only when <b>type</b> is <c>link</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public Link1? Link { get; init; }

    /// <summary>
    /// The outro text. This appears only when <b>type</b> is <c>text</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public string? Text { get; init; }

    /// <summary>
    /// The preset outro type.
    /// <para>
    /// Option descriptions:
    ///  * <c>link</c> - The outro includes a link.
    ///  * <c>no idea</c> - The outro type is <c>no idea</c>. The outro includes uploaded videos.
    ///  * <c>text</c> - The outro includes text.
    ///  * <c>uploaded_clips</c> - The outro includes uploaded videos.
    ///  * <c>uploaded_videos</c> - The outro includes uploaded videos.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type26 Type { get; init; }

    /// <summary>
    /// A comma-separated list of video URIs. This field appears only when <b>type</b> is <c>no idea</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("videos")]
    public string? Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
