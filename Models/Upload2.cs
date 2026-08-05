using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Upload2
{
    /// <summary>
    /// The upload approach.
    /// <para>
    /// Option descriptions:
    ///  * <c>post</c> - Use the POST approach.
    ///  * <c>pull</c> - Use the pull approach.
    ///  * <c>tus</c> - Use the tus approach.
    /// </para>
    /// </summary>
    [JsonPropertyName("approach")]
    public required Approach2 Approach { get; init; }

    /// <summary>
    /// The public URL at which the video is hosted. The URL must be valid for at least 24 hours. Use this parameter when <b>approach</b> is <c>pull</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }

    /// <summary>
    /// The app's redirect URL. Use this parameter when <b>approach</b> is <c>post</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_url")]
    public string? RedirectUrl { get; init; }

    /// <summary>
    /// The size in bytes of the video to upload. The maximum value of this field is <c>322122547200</c>, which corresponds to 300 GB.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("size")]
    public string? Size { get; init; }
}
