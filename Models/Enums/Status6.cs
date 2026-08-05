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
[JsonConverter(typeof(StringEnumConverter<Status6>))]
public sealed record Status6 : StringEnum<Status6>
{
    private Status6(string value) : base(value)
    {
    }

    public static readonly Status6 Complete = new("complete");

    public static readonly Status6 Error = new("error");

    public static readonly Status6 InProgress = new("in_progress");

    public static Status6 FromValue(string value) => FromValueCore(value);
}
