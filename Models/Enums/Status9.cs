using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The transcode status of the audio track.
/// <para>
/// Option descriptions:
///  * <c>complete</c> - Transcoding is complete. The audio track is available.
///  * <c>error</c> - There was a transcoding error. The audio track isn't available.
///  * <c>in_progress</c> - Transcoding is in progress. The audio track isn't available yet.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status9>))]
public sealed record Status9 : StringEnum<Status9>
{
    private Status9(string value) : base(value)
    {
    }

    public static readonly Status9 Complete = new("complete");

    public static readonly Status9 Error = new("error");

    public static readonly Status9 InProgress = new("in_progress");

    public static Status9 FromValue(string value) => FromValueCore(value);
}
