using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Upload4
{
    /// <summary>
    /// The approach by which to upload the version.
    /// <para>
    /// Option descriptions:
    ///  * <c>post</c> - Use the POST approach.
    ///  * <c>pull</c> - Use the pull approach.
    ///  * <c>tus</c> - Use the tus approach.
    /// </para>
    /// </summary>
    [JsonPropertyName("approach")]
    public required Approach4 Approach { get; init; }

    /// <summary>
    /// The public URL from which to download the version when <b>upload.approach</b> is <c>pull</c>. This URL must be valid for at least 24 hours.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }

    /// <summary>
    /// The app's redirect URL when <b>upload.approach</b> is <c>post</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_url")]
    public string? RedirectUrl { get; init; }

    /// <summary>
    /// The upload size of the version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("size")]
    public string? Size { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
