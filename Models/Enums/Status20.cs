using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The status code for the availability of the video version.
/// <para>
/// Option descriptions:
///  * <c>complete</c> - Transcoding is complete. The video version is available.
///  * <c>error</c> - There was a transcoding error. The video version isn't available.
///  * <c>in_progress</c> - Transcoding is in progress. The video version isn't available yet.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status20>))]
public sealed record Status20 : StringEnum<Status20>
{
    private Status20(string value) : base(value)
    {
    }

    public static readonly Status20 Complete = new("complete");

    public static readonly Status20 Error = new("error");

    public static readonly Status20 InProgress = new("in_progress");

    public static Status20 FromValue(string value) => FromValueCore(value);
}
