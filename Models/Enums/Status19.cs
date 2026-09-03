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
[JsonConverter(typeof(StringEnumConverter<Status19>))]
public sealed record Status19 : StringEnum<Status19>
{
    private Status19(string value) : base(value)
    {
    }

    public static readonly Status19 Done = new("done");

    public static readonly Status19 Failed = new("failed");

    public static readonly Status19 Processing = new("processing");

    public static Status19 FromValue(string value) => FromValueCore(value);
}
