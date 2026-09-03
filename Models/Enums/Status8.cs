using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The transcode status of the audio track.
/// <para>
/// Option descriptions:
///  * <c>complete</c> - Transcoding is complete. The audio track is available.
///  * <c>error</c> - There was a transcoding error. The audio track isn't available.
///  * <c>in_progress</c> - Transcoding is in progress. The audio track isn't available yet.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status8>))]
public sealed record Status8 : StringEnum<Status8>
{
    private Status8(string value) : base(value)
    {
    }

    public static readonly Status8 Complete = new("complete");

    public static readonly Status8 Error = new("error");

    public static readonly Status8 InProgress = new("in_progress");

    public static Status8 FromValue(string value) => FromValueCore(value);
}
