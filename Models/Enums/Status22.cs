using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The status of the video's edit session. This data requires a bearer token with the <c>private</c> scope.
/// <para>
/// Option descriptions:
///  * <c>done</c> - The video is finished processing.
///  * <c>failed</c> - Video processing has failed.
///  * <c>processing</c> - The video is still being processed.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status22>))]
public sealed record Status22 : StringEnum<Status22>
{
    private Status22(string value) : base(value)
    {
    }

    public static readonly Status22 Done = new("done");

    public static readonly Status22 Failed = new("failed");

    public static readonly Status22 Processing = new("processing");

    public static Status22 FromValue(string value) => FromValueCore(value);
}
