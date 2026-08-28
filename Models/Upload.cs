using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The video's upload information.
/// </summary>
public record Upload
{
    /// <summary>
    /// The approach for uploading the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>post</c> - The video upload uses the POST approach.
    ///  * <c>pull</c> - The video upload uses the pull approach.
    ///  * <c>tus</c> - The video upload uses the tus approach.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("approach")]
    public Approach? Approach { get; init; }

    /// <summary>
    /// The error that caused the upload to fail.
    /// <para>
    /// Option descriptions:
    ///  * <c>analysis_failed</c> - The uploaded file could not be decoded.
    ///  * <c>disallowed_address</c> - The URL for a 'pull' approach upload resolved to a disallowed address.
    ///  * <c>disallowed_content_type</c> - The user attempted to upload a file of an unsupported Content-Type.
    ///  * <c>duration_too_long</c> - The uploaded video exceeds the maximum allowed duration of 24 hours.
    ///  * <c>duration_too_short</c> - The uploaded video is shorter than the minimum allowed duration of 0.5 seconds.
    ///  * <c>empty_upload</c> - The user attempted to upload a 0-byte file.
    ///  * <c>exceeded_retry_count</c> - The upload failed too many times with otherwise retryable errors.
    ///  * <c>internal</c> - The upload failed due to an internal error.
    ///  * <c>invalid_redirects</c> - The URL for a 'pull' upload performed too many redirects.
    ///  * <c>max_file_size_exceeded</c> - The uploaded file exceeds the maximum allowed size of 300 GB.
    ///  * <c>missing_video_stream</c> - The uploaded file contains no video stream.
    ///  * <c>remote_bad_request</c> - The remote server for a 'pull'-approach upload responded with another 400-level status error.
    ///  * <c>remote_forbidden</c> - The remote server for a 'pull'-approach upload responded with a 'Forbidden' error.
    ///  * <c>remote_internal</c> - The remote server for a 'pull'-approach upload responded with a 500-level status error.
    ///  * <c>remote_not_found</c> - The remote server for a 'pull'-approach upload responded with a 'Not Found' error.
    ///  * <c>remote_unauthorized</c> - The remote server for a 'pull'-approach upload responded with an 'Unauthorized' error.
    ///  * <c>resolution_dimension_too_small</c> - The uploaded video's resolution has a dimension under the minimum allowed value of 2 pixels.
    ///  * <c>unsupported_video_projection</c> - The uploaded video uses an unsupported spatial projection.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("error")]
    public Error2? Error { get; init; }

    /// <summary>
    /// The HTML form for uploading a video through the POST approach.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("form")]
    public string? Form { get; init; }

    /// <summary>
    /// The ID of the Google Cloud Storage upload.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gcs_uid")]
    public string? GcsUid { get; init; }

    /// <summary>
    /// The link of the video to capture through the pull approach.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }

    /// <summary>
    /// The redirect URL for the upload app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("redirect_url")]
    public string? RedirectUrl { get; init; }

    /// <summary>
    /// The file size in bytes of the uploaded video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("size")]
    public double? Size { get; init; }

    /// <summary>
    /// The status code for the availability of the uploaded video.
    /// <para>
    /// Option descriptions:
    ///  * <c>canceled</c> - The upload was canceled.
    ///  * <c>complete</c> - The upload is complete.
    ///  * <c>error</c> - The upload ended with an error.
    ///  * <c>in_progress</c> - The upload is underway.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status8 Status { get; init; }

    /// <summary>
    /// The link for sending video file data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upload_link")]
    public string? UploadLink { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
