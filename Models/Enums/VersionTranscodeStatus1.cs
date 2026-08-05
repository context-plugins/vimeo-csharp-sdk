using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The transcode status code of the video version.
/// <para>
/// Option descriptions:
///  * <c>complete</c> - Transcoding is complete. The video version is available.
///  * <c>error</c> - There was a transcoding error. The video version isn't available.
///  * <c>in_progress</c> - Transcoding is in progress. The video version isn't available yet.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VersionTranscodeStatus1>))]
public sealed record VersionTranscodeStatus1 : StringEnum<VersionTranscodeStatus1>
{
    private VersionTranscodeStatus1(string value) : base(value)
    {
    }

    public static readonly VersionTranscodeStatus1 Complete = new("complete");

    public static readonly VersionTranscodeStatus1 Error = new("error");

    public static readonly VersionTranscodeStatus1 InProgress = new("in_progress");

    public static VersionTranscodeStatus1 FromValue(string value) => FromValueCore(value);
}
