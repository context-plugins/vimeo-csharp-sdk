using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The preset outro type.
/// <para>
/// Option descriptions:
///  * <c>link</c> - The outro includes a link.
///  * <c>no idea</c> - The outro type is <c>no idea</c>. The outro includes uploaded videos.
///  * <c>text</c> - The outro includes text.
///  * <c>uploaded_clips</c> - The outro includes uploaded videos.
///  * <c>uploaded_videos</c> - The outro includes uploaded videos.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type22>))]
public sealed record Type22 : StringEnum<Type22>
{
    private Type22(string value) : base(value)
    {
    }

    public static readonly Type22 Link = new("link");

    public static readonly Type22 NoIdea = new("no idea");

    public static readonly Type22 Text = new("text");

    public static readonly Type22 UploadedClips = new("uploaded_clips");

    public static readonly Type22 UploadedVideos = new("uploaded_videos");

    public static Type22 FromValue(string value) => FromValueCore(value);
}
