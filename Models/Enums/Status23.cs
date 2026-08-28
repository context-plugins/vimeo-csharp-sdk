using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The status code for the availability of the video version.
/// <para>
/// Option descriptions:
///  * <c>complete</c> - Transcoding is complete. The video version is available.
///  * <c>error</c> - There was a transcoding error. The video version isn't available.
///  * <c>in_progress</c> - Transcoding is in progress. The video version isn't available yet.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status23>))]
public sealed record Status23 : StringEnum<Status23>
{
    private Status23(string value) : base(value)
    {
    }

    public static readonly Status23 Complete = new("complete");

    public static readonly Status23 Error = new("error");

    public static readonly Status23 InProgress = new("in_progress");

    public static Status23 FromValue(string value) => FromValueCore(value);
}
