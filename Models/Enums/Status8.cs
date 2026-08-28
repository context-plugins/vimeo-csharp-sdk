using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Status8>))]
public sealed record Status8 : StringEnum<Status8>
{
    private Status8(string value) : base(value)
    {
    }

    public static readonly Status8 Canceled = new("canceled");

    public static readonly Status8 Complete = new("complete");

    public static readonly Status8 Error = new("error");

    public static readonly Status8 InProgress = new("in_progress");

    public static Status8 FromValue(string value) => FromValueCore(value);
}
