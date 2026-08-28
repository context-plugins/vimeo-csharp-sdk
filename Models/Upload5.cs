using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Upload5
{
    /// <summary>
    /// The type of upload approach. For more information about upload approaches, refer to <see href="https://developer.vimeo.com/api/upload/videos#understanding-upload-approaches">Working with Video Uploads</see>.
    /// <para>
    /// Option descriptions:
    ///  * <c>post</c> - The upload approach is POST.
    ///  * <c>pull</c> - The upload approach is pull.
    ///  * <c>tus</c> - The upload approach is tus.
    /// </para>
    /// </summary>
    [JsonPropertyName("approach")]
    public required Approach5 Approach { get; init; }

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
    /// The size in bytes of the asset to upload. The maximum value of this field is <c>322122547200</c>, which corresponds to 300 GB.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("size")]
    public string? Size { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
