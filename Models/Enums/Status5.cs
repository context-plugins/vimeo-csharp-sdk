using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The video's availability status.
/// <para>
/// Option descriptions:
///  * <c>complete</c> - Transcoding is complete. The video is available.
///  * <c>error</c> - There was a transcoding error. The video isn't available.
///  * <c>in_progress</c> - Transcoding is currently underway. The video isn't available yet.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status5>))]
public sealed record Status5 : StringEnum<Status5>
{
    private Status5(string value) : base(value)
    {
    }

    public static readonly Status5 Complete = new("complete");

    public static readonly Status5 Error = new("error");

    public static readonly Status5 InProgress = new("in_progress");

    public static Status5 FromValue(string value) => FromValueCore(value);
}
