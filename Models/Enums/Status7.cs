using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Status7>))]
public sealed record Status7 : StringEnum<Status7>
{
    private Status7(string value) : base(value)
    {
    }

    public static readonly Status7 Canceled = new("canceled");

    public static readonly Status7 Complete = new("complete");

    public static readonly Status7 Error = new("error");

    public static readonly Status7 InProgress = new("in_progress");

    public static Status7 FromValue(string value) => FromValueCore(value);
}
