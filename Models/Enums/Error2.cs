using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Error2>))]
public sealed record Error2 : StringEnum<Error2>
{
    private Error2(string value) : base(value)
    {
    }

    public static readonly Error2 AnalysisFailed = new("analysis_failed");

    public static readonly Error2 DisallowedAddress = new("disallowed_address");

    public static readonly Error2 DisallowedContentType = new("disallowed_content_type");

    public static readonly Error2 DurationTooLong = new("duration_too_long");

    public static readonly Error2 DurationTooShort = new("duration_too_short");

    public static readonly Error2 EmptyUpload = new("empty_upload");

    public static readonly Error2 ExceededRetryCount = new("exceeded_retry_count");

    public static readonly Error2 Internal = new("internal");

    public static readonly Error2 InvalidRedirects = new("invalid_redirects");

    public static readonly Error2 MaxFileSizeExceeded = new("max_file_size_exceeded");

    public static readonly Error2 MissingVideoStream = new("missing_video_stream");

    public static readonly Error2 RemoteBadRequest = new("remote_bad_request");

    public static readonly Error2 RemoteForbidden = new("remote_forbidden");

    public static readonly Error2 RemoteInternal = new("remote_internal");

    public static readonly Error2 RemoteNotFound = new("remote_not_found");

    public static readonly Error2 RemoteUnauthorized = new("remote_unauthorized");

    public static readonly Error2 ResolutionDimensionTooSmall = new("resolution_dimension_too_small");

    public static readonly Error2 UnsupportedVideoProjection = new("unsupported_video_projection");

    public static Error2 FromValue(string value) => FromValueCore(value);
}
